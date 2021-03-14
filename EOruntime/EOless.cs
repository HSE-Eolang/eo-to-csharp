public class EOless : EOobject
{
    public EOless(dynamic left, dynamic right)
    {
        Left = left;
        Right = right;
    }

    private dynamic Left { get; }

    private dynamic Right { get; }

    public override dynamic Φ()
    {
        return Left < Right;
    }
}
