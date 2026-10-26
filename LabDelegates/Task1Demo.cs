namespace LabDelegates;

// Завдання 1: анонімний метод і лямбда-вираз через делегат
public static class Task1Demo
{
    public static void Run()
    {
        Console.WriteLine("Завдання 1 (делегат)");

        // Анонімний метод: рахує цифри циклом
        DigitCounter anonymous = delegate (string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c)) count++;
            }
            return count;
        };

        // Лямбда-вираз: те саме коротше, через LINQ
        DigitCounter lambda = text => text.Count(char.IsDigit);

        string input = "abc123def45";

        // Виклик обох методів через делегат
        Console.WriteLine($"Рядок: {input}");
        Console.WriteLine($"Анонімний метод: {anonymous(input)}");
        Console.WriteLine($"Лямбда-вираз: {lambda(input)}");
        Console.WriteLine();
    }
}
