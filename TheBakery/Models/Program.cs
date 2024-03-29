using System;
using static System.Console;
using System.Collections.Generic;
using Bakery.Models;

class Program
{
    private static Dictionary<string, int> itemsOrdered = new Dictionary<string, int>(){
        {"bread", 0},
        {"pastry", 0}
    };
    private static int _total = 0;

    public static void Main()
    {
        Bread bakeryBread = new Bread();
        Pastry bakeryPastry = new Pastry();
        while (true)
        {
            OutputMenu();
            PurchaseSequence();
            WriteLine("Are you ready to checkout? (y/n)");
            string response = ReadLine();
            if (response.ToLower() == "y")
            {
                _total += bakeryBread.CalculateBreadCost(itemsOrdered["bread"]);
                _total += bakeryPastry.CalculatePastryCost(itemsOrdered["pastry"]);
                WriteLine("-----------------------");
                WriteLine($"Your total is ${_total}");
                WriteLine("-----------------------");
                break;
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

    public static void OutputMenu()
    {
        WriteLine("~~~ The Bakery Menu ~~~");
        WriteLine("Bread .............. $5");
        WriteLine("Pastry ............. $2");
        WriteLine("-----------------------");
    }
}
