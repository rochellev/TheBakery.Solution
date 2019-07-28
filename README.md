# The Bakery
### By Rochelle Roberts, Software Engineer
-----

## Description
* The Bakery is a C# Console App simulating the fun of buying baked goods

## Technologies Used
* C#
* .NET
* MSTest

## Installation
* Clone project repo
* From the project's root directory, open console and type dotnet run

```sh
$ git clone https://github.com/rochellev/TheBakery.Solution.git
$ cd TheBakery.Solution
$ cd TheBakery
$ dotnet restore
$ dotnet run
```

## Specs

| Behaviors       | Input          | Output      |
| ---------------- |:------------:| :--------------:|
| Start program | dotnet run | welcome message |
| See prices |  User responds "yes" to see menu | Program prints out available items and prices |
| User can purchase items | User type menu item and quantity | Cost for those items added to total |
| User can complete order | user types "checkout" | Total printed |
| Buy 2 Bread get 1 Bread free | user buys 2 Breads | 1 bread added for free |
| Buy 3 Pastries get 1 free | user buys 3 Pastries | Discount applied |

