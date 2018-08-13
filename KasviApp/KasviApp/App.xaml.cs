using System;
using Xamarin.Forms;
using KasviApp.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace KasviApp
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();
            MainPage = new Login();

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
