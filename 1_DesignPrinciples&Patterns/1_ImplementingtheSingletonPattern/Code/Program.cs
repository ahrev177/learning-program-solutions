using SingletonPattern;

class Program
{
    static void Main()
    {
        var logger1 = Logger.Instance;
        logger1.Log("First log message.");

        var logger2 = Logger.Instance;
        logger2.Log("Second log message.");

        Console.WriteLine($"Are both instances equal? {object.ReferenceEquals(logger1, logger2)}");
    }
}