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
	}
}