#define Break

using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<Repro>();
        Console.ReadKey();
    }
}

[DisassemblyDiagnoser]
public class Repro
{
    public void f0(){}
    public void f1(){}
    public void f2(){}
    public void f3(){}
    #if Break
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