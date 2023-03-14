using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_3
{
    public class Сalculator
    {
        public Сalculator()
        {
            this.SumCalculate = this.SumCalculator;
        }

        private event SumHandler SumHandler;

        public SumCalculator SumCalculate { get; set; }

        public void TrySum(SumCalculator value, int value1, int value2)
        {
            try
            {
                value.Invoke(value1, value2);
            }
            catch (Exception)
            {
                Console.WriteLine("Somthing wrong");
            }
        }

        private void SumCalculator(int value1, int value2)
        {
            this.SumHandler += this.Sum;
            this.SumHandler += this.Sum;
            int result = this.SumHandler(value1, value2);
            Console.WriteLine(result);
        }

        private int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
