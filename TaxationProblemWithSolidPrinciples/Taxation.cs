using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TaxationProblemWithSolidPrinciples.TaxRules;

namespace TaxationProblemWithSolidPrinciples
{
    static class Taxation
    {
        public static double ComputeTax(Employee emp)
        {
            IList<ITax> TaxRules = new List<ITax>();

            //var type = typeof(ITax);
            //var Rules = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes())
            //                .Where(p => type.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract);

            Assembly assembly = Assembly.Load("TaxationProblemWithSolidPrinciples");
            Type[] types = assembly.GetTypes();
            Type[] results = types.Where(x => x.GetInterface("ITax") != null).ToArray();

            foreach (Type res in results)
            {
                ITax obj = Activator.CreateInstance(res) as ITax;
                TaxRules.Add(obj);
            }

            double _totalTax = 0;
            if (TaxRules.Count == 0)
                return 0;
            foreach (var taxRule in TaxRules)
            {
                _totalTax += taxRule.CalculateTax(emp.Salary);
            }
            return _totalTax;
        }

    }
}
