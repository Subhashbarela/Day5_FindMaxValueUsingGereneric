using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MaxValueUsingGeneric.FindMaxUsingArray;

namespace MaxValueUsingGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckMaxValue max = new CheckMaxValue();
            string ans = "";
            do {
                Console.WriteLine("1: max of integer value \n2: max of float value \n3: max string value \n4: Refactor code using generic method " +
                    "\n5: using generic class \n6: Find Max Using Array");
                Console.WriteLine("Enter the choice...!");
                int choice = int.Parse(Console.ReadLine());
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
                            int intmax = GenericMethodClass.CheckMaxNumber<int>(40, 20, 30);
                            Console.WriteLine("max of int is : " + intmax);
                            float floatmax = GenericMethodClass.CheckMaxNumber<float>(4.5f, 2.45f, 30.7f);
                            Console.WriteLine("max of float is : " + floatmax);
                            string stringmax = GenericMethodClass.CheckMaxNumber<string>("Apple", "Peach", "Banana");
                            Console.WriteLine("max of string is : " + stringmax);
                            break;
                        }
                    case 5:
                        {
                            int intmax = GenericClass<int>.CheckMaxNumber(40, 50, 30);
                            Console.WriteLine("max of int is : " + intmax);
                            float floatmax = GenericClass<float>.CheckMaxNumber(4.5f, 15.45f, 12.7f);
                            Console.WriteLine("max of float is : " + floatmax);
                            string stringmax = GenericClass<string>.CheckMaxNumber("Apple", "Peach", "Banana");
                            Console.WriteLine("max of string is : " + stringmax);
                            break;
                        }
                    case 6:
                        {
                            int[] arr = { 10, 30, 24, 13, 8, 5, 15, 9 };
                            MaximumValue<int> intMaxi = new MaximumValue<int>(arr);
                            intMaxi.PrintMaxValue();
                            double[] arr2 = { 10.4, 30.6, 24.2, 13.3, 8.6 };
                            MaximumValue<double> doublMax = new MaximumValue<double>(arr2);
                            doublMax.PrintMaxValue();
                            string[] arr3 = { "Apple", "Peach", "Banana" };
                            MaximumValue<string> stringMax = new MaximumValue<string>(arr3);
                            stringMax.PrintMaxValue();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please insert valid option");
                            break;
                        }
                }
                Console.WriteLine("Do you want tocontinue..?");
                ans=Console.ReadLine();
            } while (ans=="yes" ||ans=="y");
            Console.ReadLine();
        }
    }
}
