using System;
using System.Collections.Generic;
using System.Text;

namespace TaxationProblemWithSolidPrinciples.TaxRules
{
    class ProfessionalTax : ITax
    {
        public double CalculateTax(double salary)
        {
            return .03 * salary;
        }
    }
}
