namespace OrderIn.Domain.Abstracts
{
    public abstract class ADrink
    {
        protected string _name;
        protected float _cost;
        public ADrink()
        {
            SetName();
            SetCost();
        }

        public virtual void SetName(){}
        public virtual void SetCost(){}
    }
}