﻿using System;
using System.Collections.Generic;
using System.Text;
using Assignment_2.Menu;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Combo comboTest = new Combo("Test");
            // Assignment_2.TableList.Table(); // Create 3x3 Matrix
           
            


           



            bool condition = true;

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
                        showMenu();
                        break;

                    case "2":
                        //
                        break;

                    case "3":
                        Console.WriteLine("Enter your orders number");
                        string input = Console.ReadLine();

                        Combo order = new Combo(input);
                        comboTest.Create(order);
                        break;

                    case "4":
                        //Console.WriteLine("Table dimensions");
                        //int number = Convert.ToInt32(Console.ReadLine()); read
                       // int number = 3;
                       // Table[,] tables = new Table[number, number];

                        var tablesArray = fillTables();
                        showTables(tablesArray);

                        break;


                    default:
                        condition = false;
                        break;
                }
            }


        }

        public static void showMenu(){

            Console.WriteLine("-----RESTAURANT MENU-----");
            Console.WriteLine("1. Combo 1");
            Console.WriteLine("2. Combo 2");
            Console.WriteLine("3. Combo 3");

        }

        public static List<Table> fillTables()
        {
            var result = new List<Table>();

            result.Add(new Table() { tableName = "Table 1", isAvailable = false });
            result.Add(new Table() { tableName = "Table 2", isAvailable = true });
            result.Add(new Table() { tableName = "Table 3", isAvailable = true });
            result.Add(new Table() { tableName = "Table 4", isAvailable = true });
            result.Add(new Table() { tableName = "Table 6", isAvailable = true });
            result.Add(new Table() { tableName = "Table 7", isAvailable = true });
            result.Add(new Table() { tableName = "Table 8", isAvailable = true });
            result.Add(new Table() { tableName = "Table 9", isAvailable = false });



            return result; 
        }


        public static string checkAvailability(List<Table> tablesArray)
        {

            for (int i= 0;i<9;i++)
            {
                if (tablesArray[i].isAvailable == true)
                {

                   return " is available";
                }
                else
                {
                    return " is not available";

                }
            }

            return "No more info"; 
        }

        public static void showTables(List<Table> tablesArray ) {

            foreach (var table in tablesArray)
            {
                //Console.WriteLine(table.GetInfo());
                Console.WriteLine($"{table.tableName}" + checkAvailability(tablesArray));

                
            }

        }

        



    }
}
