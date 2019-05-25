using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXAM12
{
     class Book : Product
    {
        public Book(int productId, string name, double price, string producer) : base(productId, name, price, producer) { }







        public override double computeTax()
        {
            return this.price*8/100;
        }
    }
}
