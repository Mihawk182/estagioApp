using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using ControLab.Models;
using System.Collections.Generic;
using ControLab.Repositories;
using System.Threading.Tasks;
using ControLab.Pages;

namespace ControLab.ViewMoldes
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
        }

        Command _AvancarCommand;
        public Command AvancarCommand
        {
            get { return _AvancarCommand ?? (_AvancarCommand = new Command(async () => await ExecuteAvancarCommand())); }
        }

        async Task ExecuteAvancarCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                await Navigation.PushAsync(new SelecaoSalaLab());
                IsBusy = false;
            }
        }
    }
}
