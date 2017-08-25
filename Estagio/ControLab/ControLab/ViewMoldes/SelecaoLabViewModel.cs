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
            Salas.Add(new Sala { Nome = "Laboratório de Hardware", Apelido = "Konrad Zuse"});
            Salas.Add(new Sala { Nome = "Laboratório 1", Apelido = "Alan Turing" });
            Salas.Add(new Sala { Nome = "Laboratório 2", Apelido = "Von Neumann" });
            Salas.Add(new Sala { Nome = "Laboratório 3", Apelido = "Steve Jobs" });
            Salas.Add(new Sala { Nome = "Laboratório 4", Apelido = "John Backus" });
            Salas.Add(new Sala { Nome = "Laboratório 5", Apelido = "Donald Knuth" });
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
            get { return _AvancarConfigGeralCommand ?? (_AvancarConfigGeralCommand = new Command<Sala>(async (value) => await ExecuteAvancarConfigGeralCommand(value))); }
        }

        async Task ExecuteAvancarConfigGeralCommand(Sala value)
        {
            if (!IsBusy)
            {
                IsBusy = true;
                if (value.Nome == "Laboratório de Hardware")
                {
                    await Navigation.PushAsync(new ConfigGeral());
                }
                else
                {
                    await Navigation.PushAsync(new MainPage());
                }           
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
