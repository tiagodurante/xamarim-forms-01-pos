using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MeuPrimeiroApp
{
	public partial class MyPageModal : ContentPage
	{
		public MyPageModal()
		{
			InitializeComponent();
		}

		void Comeca_deNovo(object sender, System.EventArgs e)
		{
			//DisplayAlert("Resposta", "A lata", "Obrigado Nathan");
			Navigation.PopModalAsync();
		}
	}
}
