public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double r) : base(color)
    {
        _radius = r;
    }

    public override double GetArea()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 2); 
    }
}