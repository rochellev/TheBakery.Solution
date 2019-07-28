using System;
using static System.Console;
using System.Collections.Generic;
class Program
{
    private static Dictionary<string, int> itemsOrdered = new Dictionary<string, int>(){
        {"bread", 0},
        {"pastry", 0}
    };
    private int _total = 0;
    public static void Main()
    {
        while (true)
        {
            OutputMenue();
            PurchaseSequence();
            WriteLine("Are you ready to checkout? (y/n)");
            string response = ReadLine();
            if(response.ToLower() == "n")
            {
                PurchaseSequence();
            }
            else
            {
                // calculate total
            }
        }
    }

    public static void PurchaseSequence()
    {
        WriteLine("Would you like to order Bread or Pastry?");
        string userItem = ReadLine();
        WriteLine("How many would you like?");
        int userQuantity = int.Parse(ReadLine());
        if (userItem.ToLower() == "bread")
        {
            itemsOrdered["bread"] += userQuantity;
        }
        if (userItem.ToLower() == "pastry")
        {
            itemsOrdered["pastry"] += userQuantity;
        }
    }

    public static void OutputMenue()
    {
        WriteLine("~~~ The Bakery Menu ~~~");
        WriteLine("Bread .............. $5");
        WriteLine("Pastry ............. $2");
        WriteLine("-----------------------");
    }
}
