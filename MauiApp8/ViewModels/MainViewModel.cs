using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp8.ViewModels;
internal partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
      
    }

    [ObservableProperty]
    int _clickCount = 0;

    [RelayCommand]
    void IncrementClickMeButton() => ClickCount++;
}
