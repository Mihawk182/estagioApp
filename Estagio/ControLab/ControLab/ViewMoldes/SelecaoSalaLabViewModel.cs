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
    public class SelecaoSalaLabViewModel : BaseViewModel
    {
        public SelecaoSalaLabViewModel(INavigation navigation) : base(navigation)
        {
        }

        Command _VoltaCommand;
        public Command VoltaCommand
        {
            get { return _VoltaCommand ?? (_VoltaCommand = new Command(async () => await ExecuteVoltaCommand())); }
        }

        async Task ExecuteVoltaCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                await Navigation.PopAsync();
                IsBusy = false;
            }
        }

        Command _AvancarLabCommand;
        public Command AvancarLabCommand
        {
            get { return _AvancarLabCommand ?? (_AvancarLabCommand = new Command(async () => await ExecuteAvancarLabCommand())); }
        }

        async Task ExecuteAvancarLabCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                await Navigation.PushAsync(new SelecaoLab());
                IsBusy = false;
            }
        }
    }
}
