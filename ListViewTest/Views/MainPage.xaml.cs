using System.Collections.ObjectModel;
using ListViewTest.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ListViewTest.Views;


public sealed partial class MainPage : Page
{

    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
