﻿using System;
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
        static string purchasedList = " ";
        private static string itemPrice="";
        private static float total =0;

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
            await Navigation.PushModalAsync(new CartScrn());
        }

        public static void clearpurchaseditems()
        {

            purchasedList = " ";
            itemPrice = "";
            total = 0;

        }

        public static String getpurchaseditems()
        {

            return purchasedList;
        }
        public static String getitemPrice()
        {

            return itemPrice;
        }
        public static float getTotal()
        {

            return total;
        }

        private async void LstView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("Selected", ((Products)(e.SelectedItem)).Name + " was selected.", "OK");

            purchasedList = purchasedList + ((Products)(e.SelectedItem)).Name + "\r\n";
            itemPrice=itemPrice+( ((Products)(e.SelectedItem)).Price.ToString()) + "\r\n";
            total = total + ((Products) (e.SelectedItem)).Price;

   

        }
    }
}

