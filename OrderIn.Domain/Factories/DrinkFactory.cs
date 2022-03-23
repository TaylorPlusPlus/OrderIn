using OrderIn.Domain.Abstracts;

namespace OrderIn.Domain.Factories
{
    public class DrinkFactory
    {
        public T Make<T>() where T : ADrink, new ()
        {
            return new T();
        }
    }
}