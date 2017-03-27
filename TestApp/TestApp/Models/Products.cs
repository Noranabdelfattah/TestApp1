using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public string Image { get; set; }

        public static List<Products> GetAllProducts()
        {
            return new List<Products>
        {
            new Products
            {
                Name = "Cake",
                Price = 10,
                 Image = "cake.jpg"
            },
            new Products
            {
                Name = "Pepsi",
                Price = 20,
                 Image = "pepsi.jpg"
            },
            new Products
            {
                Name = "Orange",
                Price = 30,
                 Image = "orange.jpg"
            },

            new Products
            {
                Name = "LightBulb",
                Price = 40,
                 Image = "bulb.jpg"
            },
             new Products
            {
                Name = "Torch",
                Price = 10,
                 Image = "torch.jpg"
            },
            new Products
            {
                Name = "Vacum Cleaner",
                Price = 20,
                 Image = "cleaner.jpg"
            },
              new Products
            {
                Name = "T-shirt",
                Price = 10,
                 Image = "tshirt.jpg"
            },
            new Products
            {
                Name = "Jacket",
                Price = 20,
                 Image = "jacket.jpg"
            },
            new Products
            {
                Name = "Skirt",
                Price = 30,
                 Image = "skirt.jpg"
            },

            new Products
            {
                Name = "Dress",
                Price = 40,
                Image = "dress.jpg"
            }
        };
        }

        public static List<Products> GetElectronicsProducts()
        {
            return new List<Products>
        {
            new Products
            {
                Name = "Torch",
                Price = 10,
                Image = "torch.jpg"
            },
            new Products
            {
                Name = "Vacum Cleaner",
                Price = 20,
                 Image = "cleaner"
            },
         

            new Products
            {
                Name = "LightBulb",
                Price = 40,
                 Image = "bulb.jpg"
            }

        };
        }

        public static List<Products> GetFoodProducts()
        {
            return new List<Products>
        {
            new Products
            {
                Name = "Cake",
                Price = 10,
                Image = "cake.jpg"
            },
            new Products
            {
                Name = "Pepsi",
                Price = 20,
                 Image = "pepsi.jpg"
            },
            new Products
            {
                Name = "Orange",
                Price = 30,
                 Image = "orange.jpg"
            }
        };
        }

        public static List<Products> GetClothesProducts()
        {
            return new List<Products>
        {
            new Products
            {
                Name = "T-shirt",
                Price = 10,
                 Image = "tshirt.jpg"
            },
            new Products
            {
                Name = "Jacket",
                Price = 20,
                 Image = "jacket.jpg"
            },
            new Products
            {
                Name = "Skirt",
                Price = 30,
                 Image = "skirt.jpg"
            },

            new Products
            {
                Name = "Dress",
                Price = 40,
                 Image = "dress.jpg"
            }

        };
        }
    }
}
