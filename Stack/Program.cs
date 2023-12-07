using System;
using System.Collections.Generic;

class Stack<T>
{
    private List<T> items;

    public Stack()
    {
        items = new List<T>();
    }

    public void Push(T item)
    {
        items.Add(item);
        Console.WriteLine($"Pushed: {item}");
        PrintStack();
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty. Cannot pop.");
        }

        int lastIndex = items.Count - 1;
        T poppedItem = items[lastIndex];
        items.RemoveAt(lastIndex);

        Console.WriteLine($"Popped: {poppedItem}");
        PrintStack();

        return poppedItem;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty. Cannot peek.");
        }

        return items[items.Count - 1];
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    private void PrintStack()
    {
        Console.Write("Stack: ");
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Stack<int> class
        Stack<int> intStack = new Stack<int>();

        // Perform various push and pop operations
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);

        int poppedItem = intStack.Pop();
        Console.WriteLine($"Top item without popping: {intStack.Peek()}");
        Console.WriteLine($"Is the stack empty? {intStack.IsEmpty()}");
    }
}
