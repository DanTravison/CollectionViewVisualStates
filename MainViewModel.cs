namespace SampleApp;

internal class MainViewModel
{
    public MainViewModel()
    {
        List<string> items = [];
        for (int i = 1; i <= 10; i++)
        {
            items.Add($"Item {i}");
        }
        Items = items;
    }

    public IReadOnlyList<string> Items
    {
        get;
    }
}
