namespace LabDelegates.Events;

// Компонент "стек": тут оголошена подія і метод, що її викликає
public class ItemStack
{
    // Внутрішнє сховище елементів
    private readonly List<int> _items = new();

    // Назва стеку (щоб обробник знав, хто ініціатор)
    public string Name { get; }

    // Подія очищення стеку (стандартний generic EventHandler)
    public event EventHandler<StackClearedEventArgs>? StackCleared;

    // Ініціалізація стеку
    public ItemStack(string name)
    {
        Name = name;
    }

    // Кількість елементів у стеку
    public int Count => _items.Count;

    // Додати елемент на вершину
    public void Push(int value)
    {
        _items.Add(value);
    }

    // Зняти елемент з вершини
    public int Pop()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("Стек порожній");

        int value = _items[^1];
        _items.RemoveAt(_items.Count - 1);
        return value;
    }

    // Очистити стек і повідомити підписників
    public void Clear()
    {
        int removed = _items.Count;
        _items.Clear();
        OnStackCleared(new StackClearedEventArgs(removed));
    }

    // Метод, що генерує подію (? - якщо є підписники)
    protected virtual void OnStackCleared(StackClearedEventArgs e)
    {
        StackCleared?.Invoke(this, e);
    }
}
