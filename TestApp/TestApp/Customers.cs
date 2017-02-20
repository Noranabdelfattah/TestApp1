using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Customers
    {
        public string Name { get; set; }

        public static IList<Customers> GetAllCustomers()
        {
            return new List<Customers>
        {
            new Customers
            {
                Name = "Fathala Market",
        

            },
            new Customers
            {
                Name = "Carefour ",


            },
              new Customers
            {
                Name = "Ragab Sons",


            },
        };
        }

    }
}
