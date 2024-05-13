class Calculator
{
    private List<int> _history = new();

    public int Add(int x, int y)
    {
        var result = x + y;
        
        _history.Add(result);

        return result;
    }

    public int Subtract(int x, int y)
    {
        var result = x - y;

        _history.Add(result);
        
        return result;
    }

    public int Multiply(int x, int y)
    {
        var result = x * y;

        _history.Add(result);
        
        return result;
    }

    public int Divide(int x, int y)
    {
        var result = x / y;

        _history.Add(result);

        return result;
    }

    public void PrintHistory()
    {
        Console.WriteLine("History:");
        
        foreach (var item in _history)
        {
            Console.WriteLine(item);
        }
    }
}