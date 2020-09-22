using System;
using System.Collections.Generic;
using Interfaces; 
using System.Threading.Tasks;
namespace Assignment_2
{
    public class Drink : IFood
    {
        public int Id { get; set; }
        public int drinkSize { get; set; }
        private string foodName = "Drink";

        public int DrinkSize
        {
            get { return drinkSize; }
            set { drinkSize = value; }
        }
 
        public string GetFood()
        {
            return foodName;
        }

        public  async void fillDrink(int minutesDuration = 2)
        {
            int delay = minutesDuration * 1000;


            //Console.WriteLine("Filling your drink");
            await Task.Delay(delay);
            Console.WriteLine("Your drink is ready");

        }

        public static List<Drink> BurgerMenu()
        {
            var result = new List<Drink>();

            result.Add(new Drink() { drinkSize = 500 });
            result.Add(new Drink() { drinkSize = 750 });

            return result;
        }
    }
}
