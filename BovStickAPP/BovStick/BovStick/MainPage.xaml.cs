using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BovStick
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BtnPasto.Clicked += BtnPasto_Clicked;
		}

        private async void BtnPasto_Clicked(object sender, EventArgs e)
        {
           await  Navigation.PushAsync(new Pasto());
        }
    }
}
