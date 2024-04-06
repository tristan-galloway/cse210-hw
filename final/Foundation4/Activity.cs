public abstract class Activity
{
    protected DateTime _date = new();
    protected int _length;

    public abstract int GetDistance();

    public abstract int GetSpeed();

    public abstract int GetPace();

    public abstract string GetSummary();
}