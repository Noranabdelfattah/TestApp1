using Xamarin.Forms;

namespace TestApp
{
    public partial class CustomersPage : ContentPage
    {
        private static  Customers selectedCustomer= new Customers();
        

        public CustomersPage()
        {
            InitializeComponent();

            Customer_lstView.ItemsSource = Customers.GetAllCustomers();

        }

        //public void setCustomer(Customers x)
        //{
        //    selectedCustomer = x;

        //}
        public static void setCustomerName(string x)
        {
            selectedCustomer.Name = x;

        }

        public static string getCustomerName()
        {
            return selectedCustomer.Name;
        }

        public static void clearCustomer()
        {
            selectedCustomer.Name = "Default Customer ";
        }
        //private async void LstView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    //await DisplayAlert("Navigating to POS ...", "Now you will be moved to the pos screen to start selling to "+((Customers)(e.SelectedItem)).Name , "OK");
        //    //setCustomer(((Customers)(e.SelectedItem)));
        //    //await  Navigation.PushModalAsync(new MenuPage());
      
  
        //}
    }
}
