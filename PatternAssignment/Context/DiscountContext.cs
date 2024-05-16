using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternAssignment.Discounts;

namespace PatternAssignment.Factory
{
    internal class DiscountContext
    {

        private IDiscountStrategy discountStrategy;
        
        public DiscountContext (IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public void showDiscount()
        {
            discountStrategy.discountPercent();
        }
    }
}
