using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestApp
{
    public partial class ItemsPage : ContentPage
    {
        private static IList<Products> returned_products_list;
        static String purchasedList = " ";
        public ItemsPage()
    {
            InitializeComponent();

            returned_products_list= Products.GetAllProducts();

        lstView.ItemsSource = returned_products_list;

    }

        public ItemsPage(int i)
        {
            GetValue(i);
            InitializeComponent();
           
            lstView.ItemsSource = returned_products_list;

        }

        public static void GetValue(int i)
        {
            if (i == 0)
                returned_products_list = Products.GetAllProducts();
            else if (i == 1)
                returned_products_list = Products.GetElectronicsProducts();
            else if (i == 2)
                returned_products_list = Products.GetFoodProducts();
            else
                returned_products_list = Products.GetClothesProducts();
        }

        private async void addToCartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartScrn());
        }

        public static void clearpurchaseditems()
        {

            purchasedList = " ";

        }

        public static String getpurchaseditems()
        {

            return purchasedList;
        }

        private async void LstView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("Selected", ((Products)(e.SelectedItem)).Name + " was selected.", "OK");

            purchasedList = purchasedList + ((Products)(e.SelectedItem)).Name + " , ";
        }
    }
}

