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
    class RecuperaEmailViewModel : BaseViewModel
    {
        public RecuperaEmailViewModel(INavigation navigation) : base(navigation)
        {
        }

        Command _VoltaMainCommand;
        public Command VoltaMainCommand
        {
            get { return _VoltaMainCommand ?? (_VoltaMainCommand = new Command(async () => await ExecuteVoltaMainCommand())); }
        }

        async Task ExecuteVoltaMainCommand()
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
