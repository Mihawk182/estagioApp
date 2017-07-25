using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using ControLab.Models;
using System.Collections.Generic;
using ControLab.Repositories;
using System.Threading.Tasks;
using ControLab.Pages;
using System.Net;

namespace ControLab.ViewMoldes
{
    public class ConfigGeralViewModel : BaseViewModel
    {
        public ConfigGeralViewModel(INavigation navigation) : base(navigation)
        {
        }

        Command _LigarLampadaI;
        public Command LigarLampadaI
        {
            get { return _LigarLampadaI ?? (_LigarLampadaI = new Command(async () => await ExecuteLigarLampadaI())); }
        }

        async Task ExecuteLigarLampadaI()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request =  HttpWebRequest.Create(string.Format(@"http://192.168.1.182/?function=led4_on"));
                request.ContentType = "application/json";
                request.Method = "POST";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }
                
                IsBusy = false;
            }
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
