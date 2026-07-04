class Program
{
    static void Main()
    {
        var consoleLogger = new ConsoleLogger();
        var orderProcessor = new OrderProcessor(consoleLogger);
        orderProcessor.ProcessOrder("14aw3");
    }
}