namespace Bakery.Models
{
    public class Pastry
    {
        public string Name { get; set; }
        public Pastry() { }

        // Buy 1 for \$2 or 3 for $5.
        public int CalculatePastryCost(int quantity)
        {
            int total = 0;
            int oneForTwo = 2;
            int threeForFive = 5;

            while (quantity != 0)
            {
                if(quantity < 3)
                {
                    total += oneForTwo;
                    quantity -= 1;
                }
                else
                {
                    if(quantity >= 3)
                    {
                        total += threeForFive;
                        quantity -= 3;
                    }
                }
            }
            return total;
        }
    }
}