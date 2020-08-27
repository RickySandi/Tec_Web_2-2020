using System;
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
                        int number = 3; 
                        string[,] tables = new string[number, number];

                        TableList.fillTables(tables,number);
                        TableList.showTables(tables, number);

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



    }
}
