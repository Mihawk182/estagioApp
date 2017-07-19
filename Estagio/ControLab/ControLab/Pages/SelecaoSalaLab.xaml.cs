using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControLab.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelecaoSalaLab : ContentPage
	{
		public SelecaoSalaLab ()
		{
			InitializeComponent ();
		}

        private void LabButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SalasButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void SairButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}