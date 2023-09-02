using Microsoft.UI.Xaml.Controls;

namespace ItemsViewSampleApp;
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    public MainPageViewModel ViewModel { get; } = new();
}
