using System;

namespace Dependency_Injection_Mock_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            ICalculator MyDCalculator = new DCalculator();
            Person Person1 = new Person(MyDCalculator, 6);
            Console.WriteLine(Person1.PersonCalculate());
            Console.ReadLine();
        }
    }
}
