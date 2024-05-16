using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAssignment.Discounts
{
    internal class noDiscount : IDiscountStrategy
    {
        public void discountPercent()
        {
            Console.WriteLine("Discount = No Discount (0%)");
        }
    }
}
