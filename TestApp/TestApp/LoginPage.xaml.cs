
using System;

using Xamarin.Forms;

namespace TestApp
{
    public partial class LoginPage : ContentPage
    {
        private static string loginname = " ";

        public LoginPage()
        {
            InitializeComponent();

        }

        public void SetLoginName(string x)
        {
            loginname =  x;
        }
        public static string GetLoginName()
        {
            return loginname;
        }

        private void SignIn_btn(object sender, EventArgs e)
        {
            
            SetLoginName(NameEntry.Text);
            DisplayAlert("Welcome ", "Welcome our Employee You Loged in Succsesfully Let's Start the Shift !", "Let's Go");
            Navigation.PushAsync(new HomeScreen());
        }
    }
}
