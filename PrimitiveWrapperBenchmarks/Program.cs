using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args) =>
        BenchmarkRunner.Run<Repro>(
            DefaultConfig.Instance
                .With(Job.Default
                    .WithLaunchCount(1) // how many processes to run
                    .WithId("NO BREAK"))
                .With(Job.Default
                    .WithLaunchCount(1) // how many processes to run
                    .WithCustomBuildConfiguration("BREAK")
                    .With(new [] { new MsBuildArgument("/p:Optimize=true") }) // we are using custom build configuration, so we need to tell MSBuild in explicit way to optimize the code
                    .WithId("BREAK"))
                // .With(HardwareCounter.InstructionRetired)
                // .With(new EtwProfiler(new EtwProfilerConfig()))
                .With(DisassemblyDiagnoser.Create(new DisassemblyDiagnoserConfig(printAsm: true, printPrologAndEpilog: true))));
}

public class Repro
{
    public void f0(){}
    public void f1(){}
    public void f2(){}
    public void f3(){}
#if BREAK
    public void f4(){}
#endif

    [Benchmark]
    public int First()
    {
        int x = 0;
        int comparer = 0xffffff;
        int counter = 1;
        int counter2 = 1;

        for (int i = 0; i < 0xffffff; i++)
        {
            x += i;
            x -= counter;

            if (x > counter) counter++;
            if (x < counter) counter2--;
            if (x == counter) counter2 = 5;

            comparer--;
            if (comparer == i) counter++;
        }

        return counter + counter2;
    }
}