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
    public class ConfigArViewModel : BaseViewModel
    {
        public ConfigArViewModel(INavigation navigation) : base(navigation)
        {
        }

        bool _ApplyToAll = false;
        public bool ApplyToAll
        {
            get
            {
                return _ApplyToAll;
            }
            set
            {
                _ApplyToAll = value;
                SetPropertyChanged(nameof(ApplyToAll));
            }
        }

        //=====LIGAR=================================================================================================================
        Command _LigarAR1Command;
        public Command LigarAR1Command
        {
            get { return _LigarAR1Command ?? (_LigarAR1Command = new Command(() => ExecuteLigarAR1Command())); }
        }

        void ExecuteLigarAR1Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar1Ligar"));
                request.ContentType = "application/json";
                request.Method = "POST";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteLigarAR2Command();
                    ExecuteLigarAR3Command();
                    ExecuteLigarAR4Command();
                }
            }
        }

        Command _LigarAR2Command;
        public Command LigarAR2Command
        {
            get { return _LigarAR2Command ?? (_LigarAR2Command = new Command(() => ExecuteLigarAR2Command())); }
        }

        void ExecuteLigarAR2Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar2Ligar"));
                request.ContentType = "application/json";
                request.Method = "POST";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteLigarAR1Command();
                    ExecuteLigarAR3Command();
                    ExecuteLigarAR4Command();
                }
            }
        }

        Command _LigarAR3Command;
        public Command LigarAR3Command
        {
            get { return _LigarAR3Command ?? (_LigarAR3Command = new Command(() => ExecuteLigarAR3Command())); }
        }

        void ExecuteLigarAR3Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar3Ligar"));
                request.ContentType = "application/json";
                request.Method = "POST";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteLigarAR1Command();
                    ExecuteLigarAR2Command();
                    ExecuteLigarAR4Command();
                }
            }
        }

        Command _LigarAR4Command;
        public Command LigarAR4Command
        {
            get { return _LigarAR4Command ?? (_LigarAR4Command = new Command(() => ExecuteLigarAR4Command())); }
        }

        void ExecuteLigarAR4Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar4Ligar"));
                request.ContentType = "application/json";
                request.Method = "POST";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteLigarAR1Command();
                    ExecuteLigarAR2Command();
                    ExecuteLigarAR3Command();
                }
            }
        }

        //=====DESLIGAR=================================================================================================================

        Command _DesligarAR1Command;
        public Command DesligarAR1Command
        {
            get { return _DesligarAR1Command ?? (_DesligarAR1Command = new Command(() => ExecuteDesligarAR1Command())); }
        }

        void ExecuteDesligarAR1Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar1Desligar"));
                request.ContentType = "application/json";
                request.Method = "POST";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteDesligarAR2Command();
                    ExecuteDesligarAR3Command();
                    ExecuteDesligarAR4Command();
                }
            }
        }

        Command _DesligarAR2Command;
        public Command DesligarAR2Command
        {
            get { return _DesligarAR2Command ?? (_DesligarAR2Command = new Command(() => ExecuteDesligarAR2Command())); }
        }

        void ExecuteDesligarAR2Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar2Desligar"));
                request.ContentType = "application/json";
                request.Method = "POST";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteDesligarAR1Command();
                    ExecuteDesligarAR3Command();
                    ExecuteDesligarAR4Command();
                }
            }
        }

        Command _DesligarAR3Command;
        public Command DesligarAR3Command
        {
            get { return _DesligarAR3Command ?? (_DesligarAR3Command = new Command(() => ExecuteDesligarAR3Command())); }
        }

        void ExecuteDesligarAR3Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar3Desligar"));
                request.ContentType = "application/json";
                request.Method = "POST";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteDesligarAR1Command();
                    ExecuteDesligarAR2Command();
                    ExecuteDesligarAR4Command();
                }
            }
        }

        Command _DesligarAR4Command;
        public Command DesligarAR4Command
        {
            get { return _DesligarAR4Command ?? (_DesligarAR4Command = new Command(() => ExecuteDesligarAR4Command())); }
        }

        void ExecuteDesligarAR4Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar4Desligar"));
                request.ContentType = "application/json";
                request.Method = "POST";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteDesligarAR1Command();
                    ExecuteDesligarAR2Command();
                    ExecuteDesligarAR3Command();
                }
            }
        }

        //=====CONFIRMA=TEMP=================================================================================================================
        int _TemperaturaSelectedEntry = 0;
        public int TemperaturaSelectedEntry
        {
            get
            {
                return _TemperaturaSelectedEntry;
            }
            set
            {
                _TemperaturaSelectedEntry = value;
                SetPropertyChanged(nameof(TemperaturaSelectedEntry));
            }
        }

        Command _ConfirmaTempAr1Command;
        public Command ConfirmaTempAr1Command
        {
            get { return _ConfirmaTempAr1Command ?? (_ConfirmaTempAr1Command = new Command(() => ExecuteConfirmaTempAr1Command())); }
        }

        void ExecuteConfirmaTempAr1Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                if (TemperaturaSelectedEntry == 1)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar1Temp20C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 2)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar1Temp19C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 3)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar1Temp18C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 4)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar1Temp17C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 5)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar1Temp16C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                IsBusy = false;
                if(ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteConfirmaTempAr2Command();
                    ExecuteConfirmaTempAr3Command();
                    ExecuteConfirmaTempAr4Command();
                }
            }
        }

        Command _ConfirmaTempAr2Command;
        public Command ConfirmaTempAr2Command
        {
            get { return _ConfirmaTempAr2Command ?? (_ConfirmaTempAr2Command = new Command(() => ExecuteConfirmaTempAr2Command())); }
        }

        void ExecuteConfirmaTempAr2Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                if (TemperaturaSelectedEntry == 1)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar2Temp20C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 2)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar2Temp19C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 3)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar2Temp18C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 4)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar2Temp17C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 5)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar2Temp16C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteConfirmaTempAr1Command();
                    ExecuteConfirmaTempAr3Command();
                    ExecuteConfirmaTempAr4Command();
                }
            }
        }

        Command _ConfirmaTempAr3Command;
        public Command ConfirmaTempAr3Command
        {
            get { return _ConfirmaTempAr3Command ?? (_ConfirmaTempAr3Command = new Command(() => ExecuteConfirmaTempAr3Command())); }
        }

        void ExecuteConfirmaTempAr3Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                if (TemperaturaSelectedEntry == 1)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar3Temp20C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 2)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar3Temp19C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 3)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar3Temp18C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 4)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar3Temp17C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 5)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar3Temp16C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteConfirmaTempAr1Command();
                    ExecuteConfirmaTempAr2Command();
                    ExecuteConfirmaTempAr4Command();
                }
            }
        }

        Command _ConfirmaTempAr4Command;
        public Command ConfirmaTempAr4Command
        {
            get { return _ConfirmaTempAr4Command ?? (_ConfirmaTempAr4Command = new Command(() => ExecuteConfirmaTempAr4Command())); }
        }

        void ExecuteConfirmaTempAr4Command()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                if (TemperaturaSelectedEntry == 1)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar4Temp20C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 2)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar4Temp19C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 3)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar4Temp18C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 4)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar4Temp17C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                else if (TemperaturaSelectedEntry == 5)
                {
                    var request = HttpWebRequest.Create(string.Format(@"http://10.0.0.182/Ar4Temp16C"));
                    request.ContentType = "application/json";
                    request.Method = "POST";

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                            Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    }
                }
                IsBusy = false;
                if (ApplyToAll == true)
                {
                    ApplyToAll = false;
                    ExecuteConfirmaTempAr1Command();
                    ExecuteConfirmaTempAr2Command();
                    ExecuteConfirmaTempAr3Command();
                }
            }
        }

        //=====VOLTAR=================================================================================================================

        Command _VoltaConfigGeralCommand;
        public Command VoltaConfigGeralCommand
        {
            get { return _VoltaConfigGeralCommand ?? (_VoltaConfigGeralCommand = new Command(async () => await ExecuteVoltaConfigGeralCommand())); }
        }

        async Task ExecuteVoltaConfigGeralCommand()
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
