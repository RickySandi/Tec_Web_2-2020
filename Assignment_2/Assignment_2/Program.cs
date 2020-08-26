using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Combo comboTest = new Combo("Test");
            


            bool condition = true;

            while (condition)
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("1.Show menu");
                Console.WriteLine("2.Clean Table");              //sync
                Console.WriteLine("3.Make order (name)");        //async
                //Console.WriteLine("4.Table availabilitys");
                Console.WriteLine("3.Make order (name)");

                var option = Console.ReadLine();
                switch (option)
                {

                    case "1":
                        
                        break;

                    case "2":
                        //
                        break;

                    case "3":
                        Console.WriteLine("Ingresa tu pedido");
                        string input = Console.ReadLine();

                        Combo combo1 = new Combo(input);
                        comboTest.Create(combo1);
                        break;

                    case "4":
                        //Table Availiability
                        break;


                    default:
                        condition = false;
                        break;
                }
            }


        }
    }
}
