using Xamarin.Forms;

namespace MeuPrimeiroApp
{
	public partial class MeuPrimeiroAppPage : ContentPage
	{
		public MeuPrimeiroAppPage()
		{
			//if (Device.OS == TargetPlatform.iOS)
			//{
			//	Padding = new Thickness(0, 20, 0, 0);
			//}

			Padding = Device.OnPlatform(new Thickness(20), new Thickness(0), new Thickness(0));

			Title = "EURO TREINO";
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			//DisplayAlert("Resposta", "A lata", "Obrigado Nathan");
			Navigation.PushAsync(new MyPage());
		}

		void Handle_Clicked_ARREGAO(object sender, System.EventArgs e)
		{
			//DisplayAlert("Resposta", "A lata", "Obrigado Nathan");
			Navigation.PushModalAsync(new MyPageModal());
		}
	}
}
