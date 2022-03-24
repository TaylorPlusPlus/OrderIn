using OrderIn.Domain.Abstracts;

namespace OrderIn.Domain.Models
{
    public class CokeModel:ADrink
    {
        public override void SetName()
        {
            this.Name = "Coke";
        }
        public override void SetCost()
        {
            this.Cost = 2.15f;
        }
    }

}