using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueUsingGeneric
{
    public class GenericMethodClass
    {
        public static T CheckMaxNumber<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable<T>
        {
            //Assume first value is greater than other becouse is not take any int value like max=0;
            T max = firstValue;
            //if(firstValue.CompareTo( secondValue)>0 && firstValue.CompareTo(thirdValue) >0 ||
            //    firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >0 ||
            //    firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >=0)
            //{
            //    max= firstValue;
            //}
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                max = secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                max = thirdValue;
            }
            return max;
        }
    }
}
