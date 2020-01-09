using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Addition : ICalculation
    {
        private decimal a;
        private decimal b;

        public Addition(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }
       

        public decimal Calculate()
        {
            return a + b;
        }
    }
}
