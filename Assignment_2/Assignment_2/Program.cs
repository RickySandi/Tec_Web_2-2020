﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Assignment_2.Menu;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Combo order = new Combo();
            Order pedido = new Order();
            Table table = new Table();

            var tablesArray = fillTables();

            var freeTables = tablesArray.Where(e => e.isAvailable == "available");

            //var burgerList = BurgerMenu();
            //var drinkList = DrinkMenu();

            //var combos = from burger in burgerList
            //             join drink in drinkList on burger.Id equals drink.Id
            //             select new
            //             {
            //                 burger_1 = burger.BurgerSize,
            //                 drink_1 = drink.DrinkSize,
            //                 comboName = $"Combo {burger.Id}",
            //             };

            //foreach (var joined in combos)
            //{
            //    Console.WriteLine($"Burger: {joined.burger_1} grs. - Drink: {joined.drink_1} mls. - {joined.comboName} ");
            //}
















            bool condition = true;

            Console.WriteLine("Enter your name");
            string inputName = Console.ReadLine();

            pedido.clientName = inputName;
            Console.WriteLine($"Welcome {inputName}");

            var choosenTable = cohooseTable(table, freeTables); 





            while (condition)
            {
                Console.WriteLine("-----CONSOLE MENU-----");
                Console.WriteLine("1.Show menu");
                Console.WriteLine("2.Clean Table");              //sync
                Console.WriteLine("3.Make order (name)");        //async
                Console.WriteLine("4.Table availability");
                Console.WriteLine("3.Make order (name)");

                Console.WriteLine("Type a number");
                var option = Console.ReadLine();
                switch (option)
                {

                    case "1":
                        //showMenu();
                        Assignment_2.Linq.Linq.Test();
                        break;

                    case "2":
                        //
                        break;

                    case "3":
                       
                        Table mesa = new Table();


                        showMenu();
                        Console.WriteLine("Enter your orders number");
                        string input = Console.ReadLine();

                       var combos2 = fillCombo("Combo 1");

                        //pedido.addCombo(inputName, mesa, combos);
                        pedido.addCombo("Ricky", choosenTable, combos2);
                        pedido.showOrder(choosenTable);







                        break;

                    case "4":
                        //Console.WriteLine("Table dimensions");
                        //int number = Convert.ToInt32(Console.ReadLine()); read
                        // int number = 3;
                        // Table[,] tables = new Table[number, number];

                       
                        showTables(tablesArray);

                        break;


                    default:
                        condition = false;
                        break;
                }
            }


        }

        public static void showMenu()
        {

            Console.WriteLine("-----RESTAURANT MENU-----");
            Console.WriteLine("1. Combo 1");
            Console.WriteLine("2. Combo 2");
            Console.WriteLine("3. Combo 3");

        }

        public static List<Table> fillTables()
        {
            var result = new List<Table>();

            result.Add(new Table() { tableName = "Table 1", isAvailable = "available" });
            result.Add(new Table() { tableName = "Table 2", isAvailable = "available" });
            result.Add(new Table() { tableName = "Table 3", isAvailable = "available" });
            result.Add(new Table() { tableName = "Table 4", isAvailable = "available" });
            result.Add(new Table() { tableName = "Table 6", isAvailable = "available" });
            result.Add(new Table() { tableName = "Table 7", isAvailable = "available" });
            result.Add(new Table() { tableName = "Table 8", isAvailable = "available" });
            result.Add(new Table() { tableName = "Table 9", isAvailable = "available" });



            return result;
        }




        public static void showTables(List<Table> tablesArray)
        {

            foreach (var table in tablesArray)
            {
                Console.WriteLine($"{table.tableName} {table.isAvailable}");

            }

        }

        public static Table cohooseTable(Table selectedTable, IEnumerable<Table> tables) {

           // Table choose = new Table(); 
            Console.WriteLine("Available tables");
            Console.WriteLine("Select the table of your choice");

            foreach (var table in tables)
            {

                Console.WriteLine(table.tableName);
                //choose = table; 
            }

            Console.WriteLine("Enter the Table name");
            string input = Console.ReadLine();

            selectedTable.tableName = input; 




            return selectedTable; 

        }


        public static List<Combo> fillCombo(string name)
        {

            var result = new List<Combo>();

            result.Add(new Combo() { comboName = name });


            return result;
        }
        public static List<Burger> BurgerMenu()
        {
            var result = new List<Burger>();

            result.Add(new Burger() { burgerSize = 250, Id = 1 });
            result.Add(new Burger() { burgerSize = 500, Id = 2 });

            return result;
        }

        public static List<Drink> DrinkMenu()
        {
            var result = new List<Drink>();

            result.Add(new Drink() { drinkSize = 500, Id =1 });
            result.Add(new Drink() { drinkSize = 750, Id = 2 });

            return result;
        }
    }
}
