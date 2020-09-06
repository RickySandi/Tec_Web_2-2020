using System;
using System.Collections.Generic;
using Interfaces;
using System.Threading.Tasks;
namespace Assignment_2

{
    public class Combo
    {
            // private string combos;
            public string comboName { get; set; }
            public Burger burger_1;
            public Drink drink_1;


        public void sliceBraed(int minutesDuration)
        {

            int delay = minutesDuration * 1000;

            Console.WriteLine("Filling your drink");
            Task.Delay(delay).Wait();
            Console.WriteLine("Your drink is ready");


        }

        public void cookMeat(int minutesDuration)
        {

            int delay = minutesDuration * 1000;

            Console.WriteLine("Cokking the meat");
            Task.Delay(delay).Wait();
            Console.WriteLine("Your meat is ready");

        }

        public void addCheese(int minutesDuration)
        {

            int delay = minutesDuration * 1000;
            Console.WriteLine("Adding cheese");
            Task.Delay(delay).Wait();
            Console.WriteLine("Cheese alredy added");

        }

        public void prepareBurger()
        {
            sliceBraed(2);
            cookMeat(4);
            addCheese(1);
            Console.WriteLine("Burger is ready");


        }

        public void fillDrink(int minutesDuration)
        {
            int delay = minutesDuration * 10000;

            Console.WriteLine("Filling your drink");
            Task.Delay(delay).Wait();
            Console.WriteLine("Your drink is ready");

        }




        public void selectedCombo(Combo combo)
        {

            if (combo.comboName == "Combo 1")
            {

                Console.WriteLine("You ordered Combo 1");

            }
            else if (combo.comboName == "Combo 2")
            {

                Console.WriteLine("You ordered Combo 2");

            }

            else if (combo.comboName == "Combo 3")
            {

                Console.WriteLine("You ordered Combo 2");

            }
            else
            {

                Console.WriteLine("Invalid Combo selected. Please try again");

            }


        }

    }

    
}
    

