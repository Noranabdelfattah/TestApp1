using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestApp
{
    public partial class ItemsPage : ContentPage
    {
        private static List<Products> returned_products_list;

        private static List<Products> purchasedList= new List<Products>(100);

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
                purchasedList[j]= null;
         
                total = 0;
            }
            

        }

        public static List<Products> getpurchaseditems()
        {

            return purchasedList;
        }
        //public static IList<String> getitemPrice()
        //{

        //    return itemPrice;
        //}
        public static int getTotal()
        {

            return total;
        }

        private async void LstView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("Selected", ((Products)(e.SelectedItem)).Name + " was selected.", "OK");
            if (i>=0)
            {
                purchasedList.Insert(i,(Products)(e.SelectedItem)); 
              
                total = total + ((Products) (e.SelectedItem)).Price;

            }
            i++;

        }

        private void CheckOutBtn_OnClicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new ChekOutPage());
        }

        private void ItemsSearchBar_OnSearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = itemsSearchBar.Text;
         IEnumerable <Products>  searchResult= (returned_products_list).Where(l => l.Name.Contains(keyword));
            lstView.ItemsSource = searchResult;
        }
    }
}

