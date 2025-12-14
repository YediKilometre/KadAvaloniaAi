using Avalonia.Controls;
using KadAi.ViewModels;

namespace KadAi.Views;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Image_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
    {
        if(e.ClickCount != 2)
        {
            return;
        }

        (DataContext as MainViewModel)?.SideMenuResizeCommand?.Execute(null);
    }
}