public class Shape
{
    private String _color;

    public String GetColor()
    {
        return _color;
    }
    public void SetColor(String color)
    {
        _color = color;
    }
    public Shape(String color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return 0;
    }
}