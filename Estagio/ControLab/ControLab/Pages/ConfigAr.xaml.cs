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
    }
}