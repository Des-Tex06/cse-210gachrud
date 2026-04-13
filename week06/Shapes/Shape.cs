using System.Reflection.Metadata;

public abstract class Shape
{
    private string _color;

    public Shape(string color) // This is the constructor.
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    //public virtual double GetArea()  
    //{
    //    return 0;
    //}

    public abstract double GetArea(); // Declaring a function as abstract makes it
    //an empty virtual function in the case that must be filled in by any class that inherits from shape.
    //Every class that has an abstract function must be marked as abstract.
}