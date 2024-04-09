namespace DesignPatternsNET.SOLID.OpenClose.Shapes;

public class Application
{
    public void Render(List<Shape> shapes)
    {
        for (int i = 0; i < shapes.Count; i++)
        {
            shapes[i].Render();
        }
    }
}