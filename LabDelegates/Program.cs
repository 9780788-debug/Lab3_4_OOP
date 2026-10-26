using LabDelegates;

namespace LabDelegates;

public class Program
{
    public static void Main()
    {
        // Щоб українські літери виводились правильно
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Task1Demo.Run();
        Task2Demo.Run();
    }
}
