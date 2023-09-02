using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ItemsViewSampleApp;

public class Item
{
    public string Content { get; set; } = string.Empty;
}

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Item> _items = new();

    [RelayCommand]
    private void ChangeItemsCount(int count)
    {
        Items.Clear();

        for (int i = 0; i < count; i++)
        {
            Items.Add(new Item { Content = $"Item {i + 1}" });
        }
    }
}
