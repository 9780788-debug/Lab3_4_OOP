using LabDelegates.Events;

namespace LabDelegates;

// Завдання 2-3: робота зі стеком і обробка події
public static class Task2Demo
{
    public static void Run()
    {
        Console.WriteLine("Завдання 2, 3 (подія)");

        var stack = new ItemStack("Мій стек");
        var observer = new StackObserver();

        // Підписка на подію
        stack.StackCleared += observer.OnStackCleared;

        // Додаємо три елементи
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine($"Після Push: {stack.Count} елементи");

        // Знімаємо один елемент
        Console.WriteLine($"Pop: {stack.Pop()}");

        // Очищення - спрацює обробник
        stack.Clear();

        // Відписка від події
        stack.StackCleared -= observer.OnStackCleared;

        // Після відписки обробник мовчить
        stack.Push(5);
        stack.Clear();
        Console.WriteLine("Після відписки подія не спрацювала");
    }
}
