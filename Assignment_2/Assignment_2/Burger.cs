using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces; 
namespace Assignment_2
{
    public  class Burger :IFood 
    {
        public int burgerSize { get; set; }
        private string foodName = "Burger";  

        public int BurgerSize
        {
            get { return burgerSize; }
            set { burgerSize = value; }
        }


        public string GetFood()
        {
            return foodName; 
        }

        //prepareBuerger(){

        //prepararPan()
        //prepararLechuga()
        //            .
        //            .
        //            .


        //}

        //calculatePrice

        public static List<Burger> BurgerMenu()
        {
            var result = new List<Burger>();

            result.Add(new Burger() { burgerSize = 250 });
            result.Add(new Burger() { burgerSize = 500 });

            return result;
        }

    }
    
}