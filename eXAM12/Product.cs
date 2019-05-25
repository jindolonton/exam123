﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXAM12
{
    abstract class Product
    {
       public int productId;
       public string name;
       public double price;
       public string producer;

        protected Product(int productId, string name, double price, string producer)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }
        public abstract double computeTax();
    }
}
