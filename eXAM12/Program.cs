using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXAM12
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] productsList = new Product[6];
            productsList[0] = new Book(1, "HarryPoter", 1000, "Kim Dong");
            productsList[1] = new Book(2, "book2", 2000, "nha nam");
            productsList[2] = new Book(3, "book3", 3000, "nxb tre");
            productsList[3] = new MobilePhone(4, "phone1", 30000, "apple");
            productsList[4] = new MobilePhone(5, "phone2", 40000, "samsung");
            productsList[5] = new MobilePhone(6, "phone3", 50000, "Oppo");

            double totalTax = 0;

            for(int i = 0; i < productsList.Length; i++)
            {
                
                    totalTax += productsList[i].computeTax();

                
            }
            Console.WriteLine("totlaTax:" + totalTax);
            Console.ReadKey();







        }
    }
}
