using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ControLab.ViewMoldes;

namespace ControLab.Pages
{
	public partial class ConfigAr : TabbedPage
    {
		public ConfigAr ()
		{
            BindingContext = new ConfigArViewModel(Navigation);
            InitializeComponent ();
		}

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
        }
    }
}