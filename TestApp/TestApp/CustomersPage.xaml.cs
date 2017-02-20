using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp;
using Xamarin.Forms;

namespace TestApp
{ 
    public partial class CustomersPage : ContentPage
    {
        private static  Customers selectedCustomer;

        public CustomersPage()
        {
            InitializeComponent();

            Customer_lstView.ItemsSource = Customers.GetAllCustomers();

        }

        private void setCustomer(Customers x)
        {
            selectedCustomer = x;

        }

        public static string getCustomer()
        {
            return selectedCustomer.Name;
        }

        public static void clearCustomer()
        {
            selectedCustomer = null;
        }
        private async void LstView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("Navigating to POS ...", "Now you will be moved to the pos screen to start selling to "+((Customers)(e.SelectedItem)).Name , "OK");
            setCustomer((Customers)(e.SelectedItem));
            await  Navigation.PushModalAsync(new MenuPage());
      
  
        }
    }
}
