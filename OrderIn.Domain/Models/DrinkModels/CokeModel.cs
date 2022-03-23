using OrderIn.Domain.Abstracts;

namespace OrderIn.Domain.Models
{
    public class CokeModel:ADrink
    {
        public override void SetName()
        {
            this._name = "Coke";
        }
        public override void SetCost()
        {
            this._cost = 2.15f;
        }
    }

}