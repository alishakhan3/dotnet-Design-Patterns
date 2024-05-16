using PatternAssignment.Discounts;
using PatternAssignment.Factory;

namespace PatternAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your card type:\n1. Membership Card\n2. Employee Card\n3. No Card\n(enter the option number)");
            try
            {
                int card = Convert.ToInt32(Console.ReadLine());

                if (card == 1)
                {
                    DiscountContext discount = new DiscountContext(new lowDiscount());
                    discount.showDiscount();
                }
                else if (card == 2)
                {
                    DiscountContext discount = new DiscountContext(new highDiscount());
                    discount.showDiscount();
                }
                else if (card == 3)
                {
                    DiscountContext discount = new DiscountContext(new noDiscount());
                    discount.showDiscount();
                }
                else
                {
                    Console.WriteLine("Invalid Card Type");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}
