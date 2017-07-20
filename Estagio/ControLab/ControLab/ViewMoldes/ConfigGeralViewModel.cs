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
    public class ConfigGeralViewModel : BaseViewModel
    {
        public ConfigGeralViewModel(INavigation navigation) : base(navigation)
        {
        }

        Command _AvancarConfigArCommand;
        public Command AvancarConfigArCommand
        {
            get { return _AvancarConfigArCommand ?? (_AvancarConfigArCommand = new Command(async () => await ExecuteAvancarConfigArCommand())); }
        }

        async Task ExecuteAvancarConfigArCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                await Navigation.PushAsync(new ConfigAr());
                IsBusy = false;
            }
        }

        Command _VoltaSelecaoLabCommand;
        public Command VoltaSelecaoLabCommand
        {
            get { return _VoltaSelecaoLabCommand ?? (_VoltaSelecaoLabCommand = new Command(async () => await ExecuteVoltaSelecaoLabCommand())); }
        }

        async Task ExecuteVoltaSelecaoLabCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                await Navigation.PopAsync();
                IsBusy = false;
            }
        }
    }
}
