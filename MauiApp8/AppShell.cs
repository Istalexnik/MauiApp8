using MauiApp8.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp8;

 class AppShell : Shell
{
    public AppShell(MainPage mainPage)
    {
        Items.Add(mainPage);
    }
}
