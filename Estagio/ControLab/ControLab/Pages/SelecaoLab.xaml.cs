﻿using System;
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

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            if (e == null)
            {
                return; // has been set to null, do not 'process' tapped event 
            }

            if (((SelecaoLabViewModel)BindingContext).AvancarConfigGeralCommand.CanExecute(null))
            {
                ((SelecaoLabViewModel)BindingContext).AvancarConfigGeralCommand.Execute(null);
            }
            ((ListView)sender).SelectedItem = null; // de-select the row
        }
    }
}