namespace DesignPatternsNET.SOLID.LiskovSubstitution;

public class Square : Rectangle
{
    public override void SetHeight(int height)
    {
        _height = height;
        _width = height;
    }
    
    public override void SetWidth(int width)
    {
        _width = width;
        _height = width;
    }
}