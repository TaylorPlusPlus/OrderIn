using OrderIn.Domain.Abstracts;

namespace OrderIn.Domain.Models
{
    public class Calamari : AAppetizer
    {
        protected override void FillCost()
        {
            this.Cost = 10.50f;
        }

        protected override void FillDescription()
        {
            this.Description = "Lightly fried with Buffalo sause and blue cheese";
        }

        protected override void FillName()
        {
           this.Name = "Calamari";
        }

        public double[] Tribonacci(double[] signature, int n)
        {
            double[] arr = new double[0];
            // hackonacci me
            if(n == 0)
            {
                return new double[0];
            }
            for(int i = 0; i < n; i ++)
            {
                //cases where n is less or equal to signature length
                if(i < 3)
                {
                    arr[i] = signature[i];
                }else
                {
                    arr[i] = arr[i - 1] + arr[i-2] + arr[i - 3];
                }

                //

            }
            return arr;
        }
    }
}