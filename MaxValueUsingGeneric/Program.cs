using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueUsingGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckMaxValue intMax = new CheckMaxValue();

            int max = intMax.MaximunIntegerNumber(10, 25, 20);
            Console.WriteLine("Maximum Value Is : " + max);
            Console.ReadLine();
        }
    }
}
