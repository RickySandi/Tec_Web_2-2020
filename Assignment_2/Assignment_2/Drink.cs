using System;
using System.Collections.Generic;
using Interfaces; 
namespace Assignment_2
{
    public class Drink : IFood
    {
        public int drinkSize { get; set; }
        private string foodName = "Burger";

        public int DrinkSize
        {
            get { return drinkSize; }
            set { drinkSize = value; }
        }
        //calculatePrice

        public string GetFood()
        {
            return foodName;
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
