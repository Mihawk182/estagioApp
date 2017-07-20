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

            LabListView.ItemsSource = new List<String>
            {
                "Laboratório de Hardware","Laboratório I","Laboratório II","Laboratório III","Laboratório IV","Laboratório V"
            };
        }
    }
}