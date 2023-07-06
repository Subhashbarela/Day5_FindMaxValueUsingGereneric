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
            CheckMaxValue max = new CheckMaxValue();           

            Console.WriteLine("1: max of integer value \n2: max of float value \n3: Refactor code using generic method");
            Console.WriteLine("Enter the choice...!");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        int intMax = max.MaximunIntegerNumber(10, 25, 20);
                        Console.WriteLine("Maximum int Value Is : " + intMax);
                        break;
                    }
                case 2:
                    {
                        float floatMax = max.CheckMaximumFloatNumber(10.3f, 20.5f, 2.4f);
                        Console.WriteLine("Maximum flaot Value Is : " + floatMax);
                        break;
                    } 
                
                case 3:
                    {
                        string stringMax = max.MaximunStringValue("Apple", "Peach", "Banana");
                        Console.WriteLine("Maximum Value Is : " + stringMax);
                        break;
                    }
                case 4:
                    {
                        int intmax = GenericMethod.CheckMaxNumber(40, 20, 30);
                        Console.WriteLine("max of int is : " + intmax);
                        float floatmax = GenericMethod.CheckMaxNumber(4.5f, 2.45f, 30.7f);
                        Console.WriteLine("max of float is : " + floatmax);
                        string stringmax = GenericMethod.CheckMaxNumber("Apple", "Peach", "Banana");
                        Console.WriteLine("max of string is : " + stringmax);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please insert valid option");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
