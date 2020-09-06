using System;
using Assignment_2;
namespace Interfaces
{
    public enum FoodType
    {
        _Burger,
        _Drink 
    }

    public static class FoodFactory
    {

        public static FoodType type;
        public static IFood Create()
        {
            switch (type)
            {
                case FoodType._Burger:
                    return new Burger();
                case FoodType._Drink:
                    return new Drink();
                default:
                    return null;
            }
        }
    }
}
