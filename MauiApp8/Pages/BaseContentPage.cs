using MauiApp8.Helpers;
using MauiApp8.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp8.Pages;
abstract class BaseContentPage<TViewModel> : ContentPage where TViewModel : BaseViewModel
{
    protected BaseContentPage(TViewModel viewModel, string pageTitle)
    {
        //Title = pageTitle;
        base.BindingContext = viewModel;
    }
    protected new TViewModel BindingContext => (TViewModel)base.BindingContext;

    //Hotreload
    public abstract void Build();

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        Build();
#if DEBUG
        HotReloadService.UpdateApplicationEvent += ReloadUI!;
#endif
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);

#if DEBUG
        HotReloadService.UpdateApplicationEvent -= ReloadUI!;
#endif
    }

    private void ReloadUI(Type[] obj)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Build();
        });
    }
}