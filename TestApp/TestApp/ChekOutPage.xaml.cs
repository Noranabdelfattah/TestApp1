using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestApp
{
    public partial class ChekOutPage : ContentPage
    {
        public ChekOutPage()
        {
            InitializeComponent();

            itemsNAme_lbl.ItemsSource = ItemsPage.getpurchaseditems();
          //  itemsPrice_lbl.ItemsSource = ItemsPage.getitemPrice();
            totalValue_lbl.Text = ItemsPage.getTotal().ToString();

            CustomerName_lbl.Text = "Customer Name : " + CustomersPage.getCustomerName();
              CashierName_lbl.Text = "Cashier Name : " + LoginPage.GetLoginName() +"\r\n"+DateTime.Now.ToString();
            //
        }

        

        private async void Done_OnClicked(object sender, EventArgs e)
        {
            ItemsPage.clearpurchaseditems();
            CustomersPage.clearCustomer();
  
          await  Navigation.PopToRootAsync(true);
        }
    }
}
