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
    public class SelecaoLabViewModel : BaseViewModel
    {
        public SelecaoLabViewModel(INavigation navigation) : base(navigation)
        {
            Salas.Add(new Sala { Nome = "LAB 1" });
            Salas.Add(new Sala { Nome = "LAB 2" });
        }

        ObservableCollection<Sala> _Salas = new ObservableCollection<Sala>();
        public ObservableCollection<Sala> Salas
        {
            get
            {
                return _Salas;
            }
            set
            {
                _Salas = value;
                SetPropertyChanged(nameof(Salas));
            }
        }

        Command _AvancarConfigGeralCommand;
        public Command AvancarConfigGeralCommand
        {
            get { return _AvancarConfigGeralCommand ?? (_AvancarConfigGeralCommand = new Command(async () => await ExecuteAvancarConfigGeralCommand())); }
        }

        async Task ExecuteAvancarConfigGeralCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                await Navigation.PushAsync(new ConfigGeral());
                IsBusy = false;
            }
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
