using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KasviApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
            this.InitializeComponent();
            this.BindingContext = this;
            this.IsBusy = false;

            //this.BtnLogin.Clicked += BtnLogin_Clicked;

        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            this.IsBusy = true;
        }
    }
}