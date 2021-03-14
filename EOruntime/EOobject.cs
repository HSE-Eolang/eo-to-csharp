public abstract class EOobject
{
    public static implicit operator long(EOobject obj)
    {
        return obj.Φ();
    }

    public static implicit operator string(EOobject obj)
    {
        return obj.Φ();
    }
    
    public static implicit operator bool(EOobject obj)
    {
        return obj.Φ();
    }

    public static implicit operator double(EOobject obj)
    {
        return obj.Φ();
    }

    public abstract dynamic Φ();
}