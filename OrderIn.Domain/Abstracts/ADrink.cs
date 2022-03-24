namespace OrderIn.Domain.Abstracts
{
    public class ADrink:AEntity
    {
        public string Name{get;set;}
        public float Cost{get;set;}
        protected ADrink()
        {
            SetName();
            SetCost();
        }

        public virtual void SetName(){}
        public virtual void SetCost(){}
        
        public string GetName()
        {
            return Name;
        }
    }
}