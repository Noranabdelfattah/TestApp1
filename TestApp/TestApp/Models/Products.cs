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



        public static IList<Products> GetAllProducts()
        {
            return new List<Products>
        {
            new Products
            {
                Name = "Cake",
                Price = 10,

            },
            new Products
            {
                Name = "Pepsi",
                Price = 20,

            },
            new Products
            {
                Name = "Orange",
                Price = 30,

            },

            new Products
            {
                Name = "LightBulb",
                Price = 40,

            },
             new Products
            {
                Name = "Torch",
                Price = 10,

            },
            new Products
            {
                Name = "Vacum Cleaner",
                Price = 20,

            },
              new Products
            {
                Name = "T-shirt",
                Price = 10,

            },
            new Products
            {
                Name = "Jacket",
                Price = 20,

            },
            new Products
            {
                Name = "Skirt",
                Price = 30,

            },

            new Products
            {
                Name = "Dress",
                Price = 40,

            }
        };
        }

        public static IList<Products> GetElectronicsProducts()
        {
            return new List<Products>
        {
            new Products
            {
                Name = "Torch",
                Price = 10,

            },
            new Products
            {
                Name = "Vacum Cleaner",
                Price = 20,

            },
         

            new Products
            {
                Name = "LightBulb",
                Price = 40,

            }

        };
        }

        public static IList<Products> GetFoodProducts()
        {
            return new List<Products>
        {
            new Products
            {
                Name = "Cake",
                Price = 10,

            },
            new Products
            {
                Name = "Pepsi",
                Price = 20,

            },
            new Products
            {
                Name = "Orange",
                Price = 30,

            }
        };
        }

        public static IList<Products> GetClothesProducts()
        {
            return new List<Products>
        {
            new Products
            {
                Name = "T-shirt",
                Price = 10,

            },
            new Products
            {
                Name = "Jacket",
                Price = 20,

            },
            new Products
            {
                Name = "Skirt",
                Price = 30,

            },

            new Products
            {
                Name = "Dress",
                Price = 40,

            }

        };
        }
    }
}
