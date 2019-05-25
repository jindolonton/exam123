using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXAM12
{
    class MobilePhone : Product
    {
        public MobilePhone(int productId, string name, double price, string producer) : base(productId, name, price, producer)
        {
        }

        public override double computeTax()
        {
            return this.price * 10 / 100;
        }
    }
}
