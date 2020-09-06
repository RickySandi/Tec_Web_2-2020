using System;
using System.Collections.Generic;
using Interfaces; 
namespace Assignment_2

{
    public class Combo
    {

        // private string combos;
        public string comboName { get; set; }
        //public Burger burgerType { get; set; }
       // public Drink drinkType { get; set; }

        //public Combo createCombo(string comboName, List<Combo> )
        //{
        //    Combo combo = new Combo();





        //    return combo; 


        //}



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

        //public static List<Combo> ComboMenu(IFood food)
        //{
        //    var result = new List<Combo>();

        //    result.Add(new Combo() {food. });
        //    //result.Add(new Burger() { burgerSize = 500 });

        //    return result;
        //}


        public static List<Burger> BurgerMenu()
        {
            var result = new List<Burger>();

            result.Add(new Burger() { burgerSize = 250 });
            result.Add(new Burger() { burgerSize = 500 });

            return result;
        }

        public static List<Drink> DrinkMenu()
        {
            var result = new List<Drink>();

            result.Add(new Drink() { drinkSize = 500 });
            result.Add(new Drink() { drinkSize = 750 });

            return result;
        }




    }
}
    

