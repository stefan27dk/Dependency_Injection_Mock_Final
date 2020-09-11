using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection_Mock_Final
{
    public class Person : IPerson
    {
        ICalculator Icalc; // Holder for ICalculator som man få fra konstruktoren
        int a1;

        public Person(ICalculator Icalc1, int a2)
        {
            Icalc = Icalc1;
            a1 = a2;
        }



        public int PersonCalculate()
        {
            return Icalc.Calculate(a1);
        }
    }
}
