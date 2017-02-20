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
        private Customers selectedCustomer;

        public CustomersPage()
        {
            InitializeComponent();

            Customer_lstView.ItemsSource = Customers.GetAllCustomers();

        }

        private void setCustomer(Customers x)
        {
            selectedCustomer = x;

        }

        public string getCustomer()
        {
            return selectedCustomer.Name;
        }

        private async void LstView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("Selected", ((Customers)(e.SelectedItem)).Name + " was selected.", "OK");
                setCustomer((Customers)(e.SelectedItem));
            await DisplayAlert("Navigating to POS ...", "Now you will be moved to the pos screen to start selling to"+((Customers)(e.SelectedItem)).Name , "OK");
          await  Navigation.PushModalAsync(new MenuPage());
        }
    }
}
