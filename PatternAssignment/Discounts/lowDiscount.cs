using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAssignment.Discounts
{
    internal class lowDiscount : IDiscountStrategy
    {
        public void discountPercent()
        {
            Console.WriteLine("Discount = 10%");
        }
    }
}
