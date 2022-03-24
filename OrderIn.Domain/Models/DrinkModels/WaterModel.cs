
using OrderIn.Domain.Abstracts;

namespace OrderIn.Domain.Models
{
    public class WaterModel : ADrink
    {
        public override void SetCost()
        {
            this.Cost = 0.0f;
        }
        public override void SetName()
        {
            this.Name = "Water"; 
        }
    }
}