using CommunityToolkit.Maui.Markup;
using MauiApp8.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace MauiApp8.Pages;
internal class MainPage : BaseContentPage<MainViewModel>
{
    enum Row { HelloWorld, Welcome, Count, ClickMeButton, Image }
    public MainPage(MainViewModel mainViewModel) : base(mainViewModel, "My Main Page")
    {

        Content = new Grid
        {
            RowSpacing = 25,
            Padding = 25,
            RowDefinitions = Rows.Define(
        (Row.HelloWorld, Auto),
        (Row.Welcome, Auto),
        (Row.Count, Auto),
        (Row.ClickMeButton, Auto),
        (Row.Image, Auto))
        };
    }
}
