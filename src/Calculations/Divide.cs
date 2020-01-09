using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
   public class Divide : ICalculation
    {
        private decimal a;
        private decimal b;

        public Divide(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }


        public decimal Calculate()
        {
            if (b == 0)
                throw new DivideByZeroException("divide by zero error");
            else
                return a / b;
        }
    }
}
