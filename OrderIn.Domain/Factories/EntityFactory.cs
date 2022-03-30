using OrderIn.Domain.Abstracts;

namespace OrderIn.Domain.Factories
{
    public class EntityFactory
    {
        public T Make<T>() where T : AEntity, new ()
        {
            return new T();
        }
    }
}