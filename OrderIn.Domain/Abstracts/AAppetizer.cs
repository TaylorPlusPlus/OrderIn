namespace OrderIn.Domain.Abstracts
{
    public class AAppetizer : AEntity
    {
        public string Name{get;set;}
        public float Cost{get;set;}
        public string Description{get;set;}

        public AAppetizer()
        {
            FillName();
            FillCost();
            FillDescription();
        }

        protected virtual void FillName(){}
        protected virtual void FillCost(){}
        protected virtual void FillDescription(){}

    }
}