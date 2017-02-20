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

        private async void POS_btn_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuPage());
        }

        private async void BtnRegCustomer_OnClicked(object sender, EventArgs e)
        {
          await  Navigation.PushModalAsync(new CustomersPage());
        }
    }
}
