using System.Collections.Generic;
using OrderIn.Domain.Abstracts;
using OrderIn.Domain.Factories;

namespace OrderIn.Domain.Models
{
    public class Order :AEntity
    {
        public List<ADrink> Drinks {get;set;}

        DrinkFactory drinkFactory = new DrinkFactory();

        public Order()
        {
            Drinks = new List<ADrink>();
        }
        public void AddDrink(string type)
        {
            type = type.ToUpper();
            
            switch(type)
            {
                case "COKE":
                Drinks.Add(drinkFactory.Make<CokeModel>());
                break;
                case "WATER":
                Drinks.Add(drinkFactory.Make<WaterModel>());
                break;
            }
        }
    }
}