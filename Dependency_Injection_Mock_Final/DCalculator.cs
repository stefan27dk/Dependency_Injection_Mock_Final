using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection_Mock_Final
{
   public class DCalculator : ICalculator // DCalculator implementer ICalculator interface
    {

        public int Calculate(int ad)  // Metode som skal implementeres
        {
            return ad + 5;
        }
        
    }
}
