#define Break

using System;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        var sw = Stopwatch.StartNew();
        for (int i = 0; i < 16; i++)
            new Repro().First();
        Console.WriteLine(sw.ElapsedMilliseconds);
        Console.ReadKey();
    }
}

public class Repro
{
    public void f0(){}
    public void f1(){}
    public void f2(){}
    public void f3(){}
    #if Break
    public void f4(){}
    public void f41(){}
    public void f42(){}
    public void f43(){}
    public void f44(){}
    public void f45(){}
    public void f46(){}
    public void f47(){}
    public void f48(){}
    public void f49(){}
    public void f50(){}
    public void f51(){}
    #endif

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