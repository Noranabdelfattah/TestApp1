﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    public partial class MenuPage : MasterDetailPage
    {
       CustomersPage obj =new CustomersPage();
        public MenuPage()
        {
            InitializeComponent();
           CustomerName_lbl.Text = "Customer Name :"+obj.getCustomer();
        }

        private void HomeElec_btn(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new ItemsPage(1));
            IsPresented = false;
        }

        private void Food_btn(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ItemsPage(2));
            IsPresented = false;
        }

        private void Clothes_btn(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ItemsPage(3));
            IsPresented = false;
        }
    }
}
