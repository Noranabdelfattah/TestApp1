using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestApp
{
    public partial class LoginPage : ContentPage
    {
        private static  string loginname=" Welcome : " ;

        public LoginPage()
        {
            InitializeComponent();
        }

        public void SetLoginName(string x)
        {
            loginname =loginname + x;
        }
        public static  string GetLoginName()
        {
            return loginname ;
        }

        private void SignIn_btn(object sender, EventArgs e)
        {
            SetLoginName(NameEntry.Text);
            DisplayAlert("Welcome ", "Welcome our Employee You Loged in Succsesfully Let's Start the Shift !","Let's Go");
            Navigation.PushModalAsync(new HomeScreen());
        }
    }
}
