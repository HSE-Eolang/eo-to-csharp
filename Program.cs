using System;

public class App
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер факториала");
        bool result = new EOstdout(
            $"{(long)new Factorial(new ComplexObject(long.Parse(Console.ReadLine())))}");
        Console.WriteLine("Для завершения работы нажмите любую клавишу...");
        Console.ReadKey();
    }
}

public class ComplexObject : EOobject
{
    public ComplexObject(dynamic attr1)
    {
        Attr1 = attr1;
    }

    public dynamic Attr1 { get; }

    public override dynamic Φ()
    {
        return 0;
    }
}

public class Factorial : EOobject
{
    public Factorial(dynamic n)
    {
        N = n;
    }

    public dynamic N { get; }

    public override dynamic Φ()
    {
        return new EOif(
            new EOless(N.Attr1, 2),
            1,
            new EOmul(new Factorial(new ComplexObject(new EOsub(N.Attr1, 1))), N));
    }
}
