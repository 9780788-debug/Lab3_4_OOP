namespace LabDelegates.Events;

// Клас з методом-обробником події
public class StackObserver
{
    // Обробник зі стандартною сигнатурою: (object sender, EventArgs)
    public void OnStackCleared(object? sender, StackClearedEventArgs e)
    {
        // sender - це стек, який згенерував подію
        var stack = (ItemStack)sender!;

        Console.WriteLine($"Подія: стек \"{stack.Name}\" очищено");
        Console.WriteLine($"Видалено елементів: {e.RemovedCount}");
        Console.WriteLine($"Час: {e.Time:HH:mm:ss}");
    }
}
