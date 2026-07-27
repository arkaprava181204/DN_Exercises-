using System;

class Logger
{
    
    private static Logger instance;

    
    private static readonly object lockObj = new object();

    
    private Logger()
    {
        Console.WriteLine("Singleton Instance Created");
    }

    
    public static Logger GetInstance()
    {
        lock (lockObj)
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Hello from Singleton!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger s1 = Logger.GetInstance();
        Logger s2 = Logger.GetInstance();

        s1.DisplayMessage();
        s2.DisplayMessage();

        if (s1 == s2)
        {
            Console.WriteLine("Both objects are the same instance.");
        }
        else
        {
            Console.WriteLine("Different instances created.");
        }
    }
}
