using System;
namespace Assignment_2
{
    public abstract class Food
    {
        const int TAM = 10; 
        public float Price { get; set; }
        public float PreparingTime { get; set; }


        public virtual void Ingredientes(string[] array, string value)
        {
            for (int i = 0; i < array.Length; i++){

                array[i] = value;
            }

        }

        public virtual void PrerpareFood(string foodType) {

            Console.WriteLine($"Your {foodType} is ready"); 

        }


    }
}
