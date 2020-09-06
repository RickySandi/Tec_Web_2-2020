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

        //public string calculatePrice()
        //{
        //    return totalPrice;
        //}

        public void sliceBraed(int minutesDuration) {

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

        public static List<Burger> BurgerMenu()
        {
            var result = new List<Burger>();

            result.Add(new Burger() { burgerSize = 250 });
            result.Add(new Burger() { burgerSize = 500 });

            return result;
        }

    }
    
}