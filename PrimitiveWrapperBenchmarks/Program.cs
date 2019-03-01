using System;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
#if f0
Console.WriteLine("Running f0");
#endif
#if f1
Console.WriteLine("Running f1");
#endif
#if f2
Console.WriteLine("Running f2");
#endif
#if f3
Console.WriteLine("Running f3");
#endif
#if f4
Console.WriteLine("Running f4");
#endif
#if f5
Console.WriteLine("Running f5");
#endif
#if f6
Console.WriteLine("Running f6");
#endif
#if f7
Console.WriteLine("Running f7");
#endif
#if f8
Console.WriteLine("Running f8");
#endif
#if f9
Console.WriteLine("Running f9");
#endif
#if f10
Console.WriteLine("Running f10");
#endif
#if f11
Console.WriteLine("Running f11");
#endif
#if f12
Console.WriteLine("Running f12");
#endif
#if f13
Console.WriteLine("Running f13");
#endif
#if f14
Console.WriteLine("Running f14");
#endif
#if f15
Console.WriteLine("Running f15");
#endif
#if f16
Console.WriteLine("Running f16");
#endif
#if f17
Console.WriteLine("Running f17");
#endif
#if f18
Console.WriteLine("Running f18");
#endif
#if f19
Console.WriteLine("Running f19");
#endif
#if f20
Console.WriteLine("Running f20");
#endif
#if f21
Console.WriteLine("Running f21");
#endif
#if f22
Console.WriteLine("Running f22");
#endif
#if f23
Console.WriteLine("Running f23");
#endif
#if f24
Console.WriteLine("Running f24");
#endif
#if f25
Console.WriteLine("Running f25");
#endif
#if f26
Console.WriteLine("Running f26");
#endif
#if f27
Console.WriteLine("Running f27");
#endif
#if f28
Console.WriteLine("Running f28");
#endif
#if f29
Console.WriteLine("Running f29");
#endif
#if f30
Console.WriteLine("Running f30");
#endif
#if f31
Console.WriteLine("Running f31");
#endif
#if f32
Console.WriteLine("Running f32");
#endif
#if f33
Console.WriteLine("Running f33");
#endif
#if f34
Console.WriteLine("Running f34");
#endif
#if f35
Console.WriteLine("Running f35");
#endif
#if f36
Console.WriteLine("Running f36");
#endif
#if f37
Console.WriteLine("Running f37");
#endif
#if f38
Console.WriteLine("Running f38");
#endif
#if f39
Console.WriteLine("Running f39");
#endif
#if f40
Console.WriteLine("Running f40");
#endif
#if f41
Console.WriteLine("Running f41");
#endif
#if f42
Console.WriteLine("Running f42");
#endif
#if f43
Console.WriteLine("Running f43");
#endif
#if f44
Console.WriteLine("Running f44");
#endif
#if f45
Console.WriteLine("Running f45");
#endif
#if f46
Console.WriteLine("Running f46");
#endif
#if f47
Console.WriteLine("Running f47");
#endif
#if f48
Console.WriteLine("Running f48");
#endif
#if f49
Console.WriteLine("Running f49");
#endif
#if f50
Console.WriteLine("Running f50");
#endif
#if f51
Console.WriteLine("Running f51");
#endif
#if f52
Console.WriteLine("Running f52");
#endif
#if f53
Console.WriteLine("Running f53");
#endif
#if f54
Console.WriteLine("Running f54");
#endif
#if f55
Console.WriteLine("Running f55");
#endif
#if f56
Console.WriteLine("Running f56");
#endif
#if f57
Console.WriteLine("Running f57");
#endif
#if f58
Console.WriteLine("Running f58");
#endif
#if f59
Console.WriteLine("Running f59");
#endif
#if f60
Console.WriteLine("Running f60");
#endif
#if f61
Console.WriteLine("Running f61");
#endif
#if f62
Console.WriteLine("Running f62");
#endif
#if f63
Console.WriteLine("Running f63");
#endif


        var sw = Stopwatch.StartNew();
        for (int i = 0; i < 0xF; i++)
            new Repro().Run();

        Console.WriteLine($"Took {sw.ElapsedMilliseconds} ms");
    }
}

public class Repro
{

#if f0||f1||f2||f3||f4||f5||f6||f7||f8||f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f0(){}
#endif
#if f1||f2||f3||f4||f5||f6||f7||f8||f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f1(){}
#endif
#if f2||f3||f4||f5||f6||f7||f8||f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f2(){}
#endif
#if f3||f4||f5||f6||f7||f8||f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f3(){}
#endif
#if f4||f5||f6||f7||f8||f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f4(){}
#endif
#if f5||f6||f7||f8||f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f5(){}
#endif
#if f6||f7||f8||f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f6(){}
#endif
#if f7||f8||f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f7(){}
#endif
#if f8||f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f8(){}
#endif
#if f9||f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f9(){}
#endif
#if f10||f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f10(){}
#endif
#if f11||f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f11(){}
#endif
#if f12||f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f12(){}
#endif
#if f13||f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f13(){}
#endif
#if f14||f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f14(){}
#endif
#if f15||f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f15(){}
#endif
#if f16||f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f16(){}
#endif
#if f17||f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f17(){}
#endif
#if f18||f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f18(){}
#endif
#if f19||f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f19(){}
#endif
#if f20||f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f20(){}
#endif
#if f21||f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f21(){}
#endif
#if f22||f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f22(){}
#endif
#if f23||f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f23(){}
#endif
#if f24||f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f24(){}
#endif
#if f25||f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f25(){}
#endif
#if f26||f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f26(){}
#endif
#if f27||f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f27(){}
#endif
#if f28||f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f28(){}
#endif
#if f29||f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f29(){}
#endif
#if f30||f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f30(){}
#endif
#if f31||f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f31(){}
#endif
#if f32||f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f32(){}
#endif
#if f33||f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f33(){}
#endif
#if f34||f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f34(){}
#endif
#if f35||f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f35(){}
#endif
#if f36||f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f36(){}
#endif
#if f37||f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f37(){}
#endif
#if f38||f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f38(){}
#endif
#if f39||f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f39(){}
#endif
#if f40||f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f40(){}
#endif
#if f41||f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f41(){}
#endif
#if f42||f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f42(){}
#endif
#if f43||f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f43(){}
#endif
#if f44||f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f44(){}
#endif
#if f45||f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f45(){}
#endif
#if f46||f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f46(){}
#endif
#if f47||f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f47(){}
#endif
#if f48||f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f48(){}
#endif
#if f49||f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f49(){}
#endif
#if f50||f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f50(){}
#endif
#if f51||f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f51(){}
#endif
#if f52||f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f52(){}
#endif
#if f53||f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f53(){}
#endif
#if f54||f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f54(){}
#endif
#if f55||f56||f57||f58||f59||f60||f61||f62||f63
public void f55(){}
#endif
#if f56||f57||f58||f59||f60||f61||f62||f63
public void f56(){}
#endif
#if f57||f58||f59||f60||f61||f62||f63
public void f57(){}
#endif
#if f58||f59||f60||f61||f62||f63
public void f58(){}
#endif
#if f59||f60||f61||f62||f63
public void f59(){}
#endif
#if f60||f61||f62||f63
public void f60(){}
#endif
#if f61||f62||f63
public void f61(){}
#endif
#if f62||f63
public void f62(){}
#endif
#if f63
public void f63(){}
#endif

    public int Run()
    {
        int x = 0;
        int comparer = 0xffffff;
        int counter = 1;

        for (int i = 0; i < 0xffffff; i++)
        {
            x += i;
            x -= counter;

            if (x > counter) counter++;

            comparer--;
            if (comparer == i) counter++;
        }

        return counter;
    }
}