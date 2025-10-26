
using Avalonia.Svg.Skia;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KadAi.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    //[NotifyPropertyChangedFor(nameof(SideMenuImage))]
    [NotifyPropertyChangedFor(nameof(SomeWidth))]
    public bool _sideMenuExpanded = true;

    //Assets/images/logo.svg}
    //public SvgImage SideMenuImage => new SvgImage 
    //{
    //    Source = SvgSource.Load($@"avares://{nameof(KadAi)}/Assets/images/{(SideMenuExpanded ? "logo" : "icon")}.svg")
    //};

    public int SomeWidth => _sideMenuExpanded ? 220 : 50;

    [RelayCommand]
    private void SideMenuResize()
    {
        SideMenuExpanded = !SideMenuExpanded; 
    }
}
