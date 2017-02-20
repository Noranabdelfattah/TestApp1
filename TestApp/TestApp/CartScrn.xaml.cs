using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestApp
{
    public partial class CartScrn : ContentPage
    {
        public CartScrn()
        {
       
            InitializeComponent();

            itemsNAme_lbl.Text = ItemsPage.getpurchaseditems();
            itemsPrice_lbl.Text = ItemsPage.getitemPrice();
            totalValue_lbl.Text = ItemsPage.getTotal().ToString();

            CustomerName_lbl.Text = "Customer Name : "+CustomersPage.getCustomer();
            CashierName_lbl.Text="Cashier Name : "+ LoginPage.GetLoginName();
        }
      

        private async void Done_OnClicked(object sender, EventArgs e)
        {
            ItemsPage.clearpurchaseditems();
            CustomersPage.clearCustomer();
            await Navigation.PopModalAsync();


        }
    }
}
