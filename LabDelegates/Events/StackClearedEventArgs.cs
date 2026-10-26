namespace LabDelegates.Events;

// Клас-аргумент події: дані про очищення стеку
public class StackClearedEventArgs : EventArgs
{
    // Скільки елементів було видалено
    public int RemovedCount { get; }

    // Коли відбулось очищення
    public DateTime Time { get; }

    public StackClearedEventArgs(int removedCount)
    {
        RemovedCount = removedCount;
        Time = DateTime.Now;
    }
}
