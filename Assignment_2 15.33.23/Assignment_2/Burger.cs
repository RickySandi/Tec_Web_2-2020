using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;
using System.Threading.Tasks;
namespace Assignment_2
{
    public class Burger : IFood
    {
        public int Id { get; set; }
        public int burgerSize { get; set; }
        private const string foodName = "Burger";  

        public int BurgerSize
        {
            get { return burgerSize; }
            set { burgerSize = value; }
        }

        public Burger GetBurger()
        {
            return this; 
        }


        public string GetFood()
        {
            return foodName; 
        }


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

        public static List<Burger> BurgerMenu()
        {
            var result = new List<Burger>();

            result.Add(new Burger() { burgerSize = 250 });
            result.Add(new Burger() { burgerSize = 500 });

            return result;
        }

    }
    
}