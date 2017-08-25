using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ControLab.ViewMoldes;

namespace ControLab.Pages
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            BindingContext = new MainPageViewModel(Navigation);
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
