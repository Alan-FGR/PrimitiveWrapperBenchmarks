using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StructHashCodeTest>();
        //Console.ReadKey();
    }
}

[SimpleJob(RunStrategy.Throughput, 2, 2, 8, 8)]
public class StructHashCodeTest
{
    public static IEnumerable<int> KeySource => Enumerable.Range(0, 0xfffff);
    public static Dictionary<int, int> IntKeyedDic = KeySource.ToDictionary(x => x, x => x);
    public static Dictionary<Wrapper, int> StandardWrapperKeyedDic = KeySource.ToDictionary(x => new Wrapper(x), x => x);

    //[Benchmark]
    public int IntKeyed()
    {
        var retval = 0;
        foreach (var key in IntKeyedDic.Keys)
            retval += IntKeyedDic[key];
        return retval;
    }

    //[Benchmark]
    public int StandardIntWrapperKeyed()
    {
        var retval = 0;
        foreach (var key in StandardWrapperKeyedDic.Keys)
            retval += StandardWrapperKeyedDic[key];
        return retval;
    }

    [Benchmark]
    public int EqualDirect()
    {
        int compare = 0xffffff;
        int matches = 0;
        for (int i = 0; i < 0xffffff; i++)
        {
            if (compare == i)
                matches++;

            compare--;
        }

        return matches;
    }

    [Benchmark]
    public int EqualWrapped()
    {
        Wrapper compare = 0xffffff;
        Wrapper matches = 0;
        for (Wrapper i = 0; i < 0xffffff; i++)
        {
            if (compare == i)
                matches++;

            compare--;
        }

        return (int) matches;
    }

    [Benchmark]
    public int manyOpsDirect()
    {
        int compare = 0xffffff;
        int x = 0;
        int b = 0;

        int bogus = 1;
        int bogus2 = 1;

        for (int i = 0; i < 0xffffff; i++)
        {
            x += i;
            x -= bogus;

            if (x > bogus) bogus++;
            if (x < bogus) bogus2--;
            if (x == bogus) bogus2 = 5;

            compare--;
            if (compare == i) bogus++;
        }

        return bogus + bogus2;
    }

    [Benchmark]
    public int manyOpsWrapper()
    {
        Wrapper compare = 0xffffff;
        Wrapper x = 0;
        Wrapper b = 0;

        Wrapper bogus = 1;
        Wrapper bogus2 = 1;

        for (Wrapper i = 0; i < 0xffffff; i++)
        {
            x += i;
            x -= bogus;

            if (x > bogus) bogus++;
            if (x < bogus) bogus2--;
            if (x == bogus) bogus2 = 5;

            compare--;
            if (compare == i) bogus++;
        }

        return (int) (bogus + bogus2);
    }

}

public readonly struct Wrapper : IEquatable<Wrapper>, IComparable<Wrapper>
{
    private int Value { get; }

    public Wrapper(int value) => Value = value;

    // object overrides
    public override bool Equals(object obj) => obj is Wrapper other && Value == other.Value;
    public override int GetHashCode() => Value.GetHashCode();
    public override string ToString() => Value.ToString();

    // Operators
    public static bool operator <(Wrapper left, Wrapper right)  => left.Value < right.Value;
    public static bool operator >(Wrapper left, Wrapper right)  => left.Value > right.Value;
    public static bool operator <=(Wrapper left, Wrapper right) => left.Value <= right.Value;
    public static bool operator >=(Wrapper left, Wrapper right) => left.Value >= right.Value;
    public static bool operator ==(Wrapper left, Wrapper right) => left.Value == right.Value;
    public static bool operator !=(Wrapper left, Wrapper right) => left.Value != right.Value;
    public static Wrapper operator +(Wrapper left, Wrapper right) => left.Value + right.Value;
    public static Wrapper operator -(Wrapper left, Wrapper right) => left.Value - right.Value;
    public static Wrapper operator *(Wrapper left, Wrapper right) => left.Value * right.Value;
    public static Wrapper operator /(Wrapper left, Wrapper right) => left.Value / right.Value;
    public static Wrapper operator %(Wrapper left, Wrapper right) => left.Value % right.Value;
    public static Wrapper operator &(Wrapper left, Wrapper right) => left.Value & right.Value;
    public static Wrapper operator |(Wrapper left, Wrapper right) => left.Value | right.Value;
    public static Wrapper operator ^(Wrapper left, Wrapper right) => left.Value ^ right.Value;
    public static Wrapper operator <<(Wrapper left, int right) => left.Value << right;
    public static Wrapper operator >>(Wrapper left, int right) => left.Value >> right;
    public static Wrapper operator ++(Wrapper prev) => prev.Value+1;
    public static Wrapper operator --(Wrapper prev) => prev.Value-1;
    public static Wrapper operator ~(Wrapper prev) => ~prev.Value;
    public static Wrapper operator +(Wrapper prev) => +prev.Value;
    public static Wrapper operator -(Wrapper prev) => -prev.Value;

    // Interfaces
    public bool Equals(Wrapper other) => Value == other.Value;
    public int CompareTo(Wrapper other) => Value.CompareTo(other.Value);

    // Casts
    public static implicit operator Wrapper(int @int) => new Wrapper(@int);
    public static explicit operator int(Wrapper w) => w.Value;
}