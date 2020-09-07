using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Assignment_2. Linq
{
    public class Linq
    {
        public static void Test()
        {
            var burgerList = BurgerMenu();
            var drinkList = DrinkMenu();

            var combos = from burger in burgerList
                         join drink in drinkList on burger.Id equals drink.Id
                         select new
                         {
                             burger_1 = burger.BurgerSize,
                             drink_1 = drink.DrinkSize,
                             comboName = $"Combo {burger.Id}",
                         };

            foreach (var joined in combos)
            {
                Console.WriteLine($"Burger: {joined.burger_1} grs. - Drink: {joined.drink_1} mls. - {joined.comboName} ");
            }





        }
        public static List<Burger> BurgerMenu()
        {
            var result = new List<Burger>();

            result.Add(new Burger() { burgerSize = 250, Id = 1 });
            result.Add(new Burger() { burgerSize = 500, Id = 2 });

            return result;
        }

        public static List<Drink> DrinkMenu()
        {
            var result = new List<Drink>();

            result.Add(new Drink() { drinkSize = 500, Id = 1 });
            result.Add(new Drink() { drinkSize = 750, Id = 2 });

            return result;
        }


    }
}
