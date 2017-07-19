using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ControLab.ViewMoldes;

namespace ControLab.Pages
{
    public partial class SelecaoLab : ContentPage
    {
        public SelecaoLab()
        {
            BindingContext = new SelecaoLabViewModel(Navigation);
            InitializeComponent();
        }
    }
}