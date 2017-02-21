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

        private static IList<string> purchasedList= new List<string>(100);
        private static IList<string> itemPrice = new List<string>(100);
        private static int total =0;
        private int i = 0;
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

        public static void clearpurchaseditems()
        {
            for (int j = 0; j < purchasedList.Count; j++)
            {
                purchasedList[j]= " ";
                itemPrice [j] = " ";
                total = 0;
            }
            

        }

        public static IList<String> getpurchaseditems()
        {

            return purchasedList;
        }
        public static IList<String> getitemPrice()
        {

            return itemPrice;
        }
        public static int getTotal()
        {

            return total;
        }

        private async void LstView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("Selected", ((Products)(e.SelectedItem)).Name + " was selected.", "OK");
            if (i>=0)
            {
                purchasedList.Insert(i,((Products)(e.SelectedItem)).Name); 
                itemPrice.Insert(i, ((((Products) (e.SelectedItem)).Price)).ToString()) ;
                total = total + ((Products) (e.SelectedItem)).Price;

            }
            i++;

        }

        private void CheckOutBtn_OnClicked(object sender, EventArgs e)
        {
             Navigation.PushModalAsync(new ChekOutPage());
        }
    }
}

