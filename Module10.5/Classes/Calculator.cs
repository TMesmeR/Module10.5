using Module10._5.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10._5.Classes
{
    internal class Calculator: ICalculator
    {
        double? num1 = null;
        double? num2 = null;
        Logger logger { get; set; }
        public Calculator(Logger logger)
        {
            this.logger = logger;
        }

        public double? Sum(double? a, double? b)
        {
            return a + b;
        }
        public void Print()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое число:");
                    num1 = double.Parse(Console.ReadLine().Replace(".", "."), CultureInfo.InvariantCulture);
                    Console.WriteLine("Введите второе число");
                    num2 = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);

                    logger.Event("Ответ: " + Sum(num1, num2));
                    Console.WriteLine();
                   
                }
                catch
                {
                    logger.Error("Введите число");
                }
            }

        }
    }
}
