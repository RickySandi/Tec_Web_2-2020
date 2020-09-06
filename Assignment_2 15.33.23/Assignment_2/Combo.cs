using System;
using System.Collections.Generic;
using Interfaces; 
namespace Assignment_2

{
    public class Combo
    {
            // private string combos;
            public string comboName { get; set; }
        //public List<Burger> burgerList { get; set; }
        //public List<Drink> drinkList { get; set; }


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
    

