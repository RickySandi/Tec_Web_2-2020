using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ABB_Array<int>* abb = new ABB_Array<int>();

            bool condition = true;

            while (condition)
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("1.Show menu");
                Console.WriteLine("2.Clean Table");              //sync
                Console.WriteLine("3.Make order (name)");
                //Console.WriteLine("4.Table availability (name)");//async

                var option = Console.ReadLine();
                switch (option)
                {

                    case "1":
                        //
                        break;

                    case "2":
                        //
                        break;

                    case "3":
                        //
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
