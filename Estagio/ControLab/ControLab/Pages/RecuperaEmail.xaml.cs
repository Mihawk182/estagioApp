using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ControLab.ViewMoldes;

namespace ControLab.Pages
{
	public partial class RecuperaEmail : ContentPage
	{
		public RecuperaEmail ()
		{
            BindingContext = new RecuperaEmailViewModel(Navigation);
            InitializeComponent ();
		}
	}
}