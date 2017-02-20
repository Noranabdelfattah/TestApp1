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
       
            this.Title = "Your Reciept";

            Label lablView = new Label();

            lablView.Text = ItemsPage.getpurchaseditems();

            Button Done = new Button();
            Done.Text = "OK Print The recipt ";
            Done.Clicked += async (sender, e) => {
            ItemsPage.clearpurchaseditems();
                await Navigation.PopToRootAsync();

            };
            Content = new StackLayout
            {
                Children = {
                    lablView, Done

                    }
            };
        }
    }
}
