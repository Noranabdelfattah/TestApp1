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
            CashierName_lbl.Text = "Cashier Name : " + LoginPage.GetLoginName();
            for (int i = 0; i < Customers.GetAllCustomers().Count; i++)
            {
                CustomersPicker.Items.Add(Customers.GetAllCustomers().ElementAt(i).Name);
            }

        }

        private async void POS_btn_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }

        private async void BtnRegCustomer_OnClicked(object sender, EventArgs e)
        {
          await  Navigation.PushModalAsync(new CustomersPage());
        }

        private async void BtnCashier_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }

        private void CustomersPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string name=CustomersPicker.Items[CustomersPicker.SelectedIndex];
            DisplayAlert(name, "Selected","OK");
            CustomersPage.setCustomerName(name);
        }
    }
}
