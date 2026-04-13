class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return 3.14 * _radius * _radius; // The solution used Math.PI instead of 3.14 as I did.
    }
}