﻿using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using ControLab.Models;
using System.Collections.Generic;
using ControLab.Repositories;
using System.Threading.Tasks;
using ControLab.Pages;

namespace ControLab.ViewMoldes
{
    public class SelecaoLabViewModel : BaseViewModel
    {
        public SelecaoLabViewModel(INavigation navigation) : base(navigation)
        {
        }

        Command _VoltaLabCommand;
        public Command VoltaLabCommand
        {
            get { return _VoltaLabCommand ?? (_VoltaLabCommand = new Command(async () => await ExecuteVoltaLabCommand())); }
        }

        async Task ExecuteVoltaLabCommand()
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
