using System;
namespace Bakery.Models
{
    public class Bread
    {

        public string Name { get; set; }
        public Bread() { }

        // buy 2 get one free
        public int CalculateBreadCost(int quantity)
        {
            int total = 0;
            int oneForFive = 5;
            int threeForTen = 10;

            while (quantity != 0)
            {
                if (quantity == 1)
                {
                    total += oneForFive;
                    quantity -= 1;
                }
                else
                {
                    if(quantity >= 3)
                    {
                        quantity -=3;
                        total += threeForTen;
                    }
                    else
                    {
                        quantity -=1;
                        total += oneForFive;
                    }
                }
            }

            return total;
        }

    }
}