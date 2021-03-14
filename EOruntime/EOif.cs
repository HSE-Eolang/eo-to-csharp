public class EOif : EOobject
{
    public EOif(dynamic condition, dynamic result1, dynamic result2)
    {
        Condition = condition;
        Result1 = result1;
        Result2 = result2;
    }

    private dynamic Condition { get; }

    private dynamic Result1 { get; }

    private dynamic Result2 { get; }

    public override dynamic Φ()
    {
        return Condition ? Result1 : Result2;
    }
}