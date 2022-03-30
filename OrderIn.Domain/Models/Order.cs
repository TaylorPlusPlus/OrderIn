using System.Collections.Generic;
using OrderIn.Domain.Abstracts;
using OrderIn.Domain.Factories;

namespace OrderIn.Domain.Models
{
    public class Order :AEntity
    {
        public List<ADrink> Drinks {get;set;}
        public List<AAppetizer> Appetizers {get;set;}

        DrinkFactory drinkFactory = new DrinkFactory();
        EntityFactory EntityFactory = new EntityFactory();

        public Order()
        {
            Drinks = new List<ADrink>();
            Appetizers = new List<AAppetizer>();
        }

        public void AddAppetizers(string type)
        {
            type = type.ToUpper();
            
            switch(type)
            {
                case "CALAMARI":
                Appetizers.Add(EntityFactory.Make<Calamari>());
                break;
            }
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