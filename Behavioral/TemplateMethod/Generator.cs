namespace DesignPatternsNET.Behavioral.TemplateMethod;

public abstract class Generator
{
    public void Generate()
    {
        GetData();
        PrepareData();
        GenerateFile();
        SendFile();
    }
    
    protected virtual void GetData()
    {
        Console.WriteLine("Getting data...");
    }

    protected abstract void PrepareData();
    protected abstract void GenerateFile();

    private void SendFile()
    {
        Console.WriteLine("Sending file...");
    }
}