using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ControLab.ViewMoldes;

namespace ControLab.Pages
{
	public partial class SelecaoSalaLab : ContentPage
	{
		public SelecaoSalaLab ()
		{
            BindingContext = new SelecaoSalaLabViewModel(Navigation);
            InitializeComponent();
		}
    }
}