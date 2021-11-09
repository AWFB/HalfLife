using System;

namespace HalfLife
{
    class Program
    {
        // TODO - give chemo or not logic
        static void Main(string[] args)
        {
            Console.Write("What is the first concentration (ng/L)?:");
            double initialConcentration = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many hours post surgery?:");
            double time = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("What is the concentration now (ng/L)?:");
            double concentrationNow = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many hours post surgery?:");
            double timeTwo = Convert.ToDouble(Console.ReadLine());

            var calculate = new HalfLifeLibrary.HalfLifeCalculation();
            var result = calculate.Calc(time, timeTwo, concentrationNow, initialConcentration);
            Console.WriteLine(result);
        }
    }
}