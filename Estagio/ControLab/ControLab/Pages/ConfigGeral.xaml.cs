using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ControLab.ViewMoldes;

namespace ControLab.Pages
{
	public partial class ConfigGeral : ContentPage
	{
		public ConfigGeral ()
		{
            BindingContext = new ConfigGeralViewModel(Navigation);
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           /* if (((ConfigGeralViewModel)BindingContext).PegaTempCommand.CanExecute(null))
            {
                ((ConfigGeralViewModel)BindingContext).PegaTempCommand.Execute(null);
            }
            if (((ConfigGeralViewModel)BindingContext).PegaUmidCommand.CanExecute(null))
            {
                ((ConfigGeralViewModel)BindingContext).PegaUmidCommand.Execute(null);
            }
            if (((ConfigGeralViewModel)BindingContext).PegaLumiCommand.CanExecute(null))
            {
                ((ConfigGeralViewModel)BindingContext).PegaLumiCommand.Execute(null);
            }*/
        }
    }
}