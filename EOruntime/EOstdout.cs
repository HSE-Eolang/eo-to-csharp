using System;

public class EOstdout : EOobject
{
    public EOstdout(dynamic value)
    {
        Value = value;
    }

    private dynamic Value { get; }

    public override dynamic Φ()
    {
        Console.WriteLine((string)Value);
        return true;
    }
}
