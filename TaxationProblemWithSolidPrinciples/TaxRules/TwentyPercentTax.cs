using System;
using System.Collections.Generic;
using System.Text;

namespace TaxationProblemWithSolidPrinciples.TaxRules
{
    class TwentyPercentTax : ITax
    {
        public double CalculateTax(double salary)
        {
            return .2 * salary;
        }
    }
}
