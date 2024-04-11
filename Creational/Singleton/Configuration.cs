namespace DesignPatternsNET.Creational.Singleton;

public class Configuration
{
    private static Configuration _instance = null;
    private static object obj = new ();
    public string StringProperty { get; set; }
    public int IntProperty { get; set; }
    
    private Configuration() {}

    public static Configuration Instance()
    {
        lock (obj)
        {
            if (_instance == null) _instance = new Configuration();
        }

        return _instance;
    }
}