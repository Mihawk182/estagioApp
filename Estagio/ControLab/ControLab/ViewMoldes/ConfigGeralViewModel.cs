using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using ControLab.Models;
using System.Collections.Generic;
using ControLab.Repositories;
using System.Threading.Tasks;
using ControLab.Pages;
using System.Net;
using System.IO;

namespace ControLab.ViewMoldes
{
    public class ConfigGeralViewModel : BaseViewModel
    {
        public ConfigGeralViewModel(INavigation navigation) : base(navigation)
        {
        }

        string _TempEntryCommand = string.Empty;
        public string TempEntryCommand
        {
            get
            {
                return _TempEntryCommand;
            }
            set
            {
                _TempEntryCommand = value;
                SetPropertyChanged(nameof(TempEntryCommand));
            }
        }

        string _UmidEntryCommand = string.Empty;
        public string UmidEntryCommand
        {
            get
            {
                return _UmidEntryCommand;
            }
            set
            {
                _UmidEntryCommand = value;
                SetPropertyChanged(nameof(UmidEntryCommand));
            }
        }

        string _LumiProgressBarCommand = string.Empty;
        public string LumiProgressBarCommand
        {
            get
            {
                return _LumiProgressBarCommand;
            }
            set
            {
                _LumiProgressBarCommand = value;
                SetPropertyChanged(nameof(LumiProgressBarCommand));
            }
        }

        Command _LigarLampadaICommand;
        public Command LigarLampadaICommand
        {
            get { return _LigarLampadaICommand ?? (_LigarLampadaICommand = new Command(() => ExecuteLigarLampadaICommand())); }
        }

        void ExecuteLigarLampadaICommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request =  HttpWebRequest.Create(string.Format(@"http://10.0.0.182/LigarL1"));
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

        Command _LigarLampadaIICommand;
        public Command LigarLampadaIICommand
        {
            get { return _LigarLampadaIICommand ?? (_LigarLampadaIICommand = new Command(() => ExecuteLigarLampadaIICommand())); }
        }

        void ExecuteLigarLampadaIICommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/LigarL2"));
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

        Command _LigarLampadaIIICommand;
        public Command LigarLampadaIIICommand
        {
            get { return _LigarLampadaIIICommand ?? (_LigarLampadaIIICommand = new Command(() => ExecuteLigarLampadaIIICommand())); }
        }

        void ExecuteLigarLampadaIIICommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/LigarL3"));
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

        Command _LigarLampadaIVCommand;
        public Command LigarLampadaIVCommand
        {
            get { return _LigarLampadaIVCommand ?? (_LigarLampadaIVCommand = new Command(() => ExecuteLigarLampadaIVCommand())); }
        }

        void ExecuteLigarLampadaIVCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/LigarL4"));
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

        Command _PegaTempCommand;
        public Command PegaTempCommand
        {
            get { return _PegaTempCommand ?? (_PegaTempCommand = new Command(() => ExecutePegaTempCommand())); }
        }

        void ExecutePegaTempCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Temperatura"));
                request.ContentType = "application/json";
                request.Method = "GET";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string content = reader.ReadToEnd();
                        if (string.IsNullOrWhiteSpace(content))
                        {
                            Console.Out.WriteLine("Response contained empty body...");
                        }
                        else
                        {
                            TempEntryCommand = content;
                        }
                    }
                }

                IsBusy = false;
            }
        }

        Command _PegaUmidCommand;
        public Command PegaUmidCommand
        {
            get { return _PegaUmidCommand ?? (_PegaUmidCommand = new Command(() => ExecutePegaUmidCommand())); }
        }

        void ExecutePegaUmidCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Umidade"));
                request.ContentType = "application/json";
                request.Method = "GET";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string content = reader.ReadToEnd();
                        if (string.IsNullOrWhiteSpace(content))
                        {
                            Console.Out.WriteLine("Response contained empty body...");
                        }
                        else
                        {
                            UmidEntryCommand = content;
                        }
                    }
                }

                IsBusy = false;
            }
        }

        Command _PegaLumiCommand;
        public Command PegaLumiCommand
        {
            get { return _PegaLumiCommand ?? (_PegaLumiCommand = new Command(() => ExecutePegaLumiCommand())); }
        }

        void ExecutePegaLumiCommand()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Luminosidade"));
                request.ContentType = "application/json";
                request.Method = "GET";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string content = reader.ReadToEnd();
                        if (string.IsNullOrWhiteSpace(content))
                        {
                            Console.Out.WriteLine("Response contained empty body...");
                        }
                        else
                        {
                            LumiProgressBarCommand = content;
                        }
                    }
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
