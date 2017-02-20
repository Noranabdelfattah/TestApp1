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

            lablView.Text = ItemsPage.getpurchaseditems();
        }


        private async void Done_OnClicked(object sender, EventArgs e)
        {
            ItemsPage.clearpurchaseditems();
            await Navigation.PopToRootAsync();

        }
    }
}
