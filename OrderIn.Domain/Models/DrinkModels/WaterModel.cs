
using OrderIn.Domain.Abstracts;

namespace OrderIn.Domain.Models
{
    public class WaterModel : ADrink
    {
        public override void SetCost()
        {
            this._cost = 0.0f;
        }
        public override void SetName()
        {
            this._name = "Water"; 
        }
    }
}