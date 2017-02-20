using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestApp
{
    public partial class HomeScreen : ContentPage
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuPage());
        }
    }
}
