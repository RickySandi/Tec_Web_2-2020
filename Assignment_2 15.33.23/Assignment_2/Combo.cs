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
            public int comboPrice { get; set; }


        public  async void sliceBraed(int minutesDuration)
        {

            int delay = minutesDuration * 1000;

            //Console.WriteLine("Slicing the bread");
            await Task.Delay(delay);
           // Console.WriteLine("Bread is ready");


        }
       

        public  async void cookMeat(int minutesDuration)
        {

            int delay = minutesDuration * 1000;

        //    Console.WriteLine("Cooking the meat");
            await Task.Delay(delay);
          //  Console.WriteLine("Your meat is ready");

        }

        public  async void addCheese(int minutesDuration)
        {

            int delay = minutesDuration * 1000;
//            Console.WriteLine("Adding cheese");
            await Task.Delay(delay);
           // Console.WriteLine("Cheese alredy added");

        }

        public  async void prepareBurger()
        {
            sliceBraed(2);
            await Task.Delay(2000);
            cookMeat(4);
            addCheese(12);
            
            Console.WriteLine("Burger is ready");
        }

        public  async void fillDrink(int minutesDuration=2)
        {
            int delay = minutesDuration * 1000;


            //Console.WriteLine("Filling your drink");
            await Task.Delay(delay);
            Console.WriteLine("Your drink is ready");

        }

    }

    
}
    

