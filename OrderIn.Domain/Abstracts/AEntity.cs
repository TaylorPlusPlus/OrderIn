namespace OrderIn.Domain.Abstracts
{
    public abstract class AEntity
    {
        public long EntityId {get;set;}
        
        protected AEntity()
        {

        }
    }
}