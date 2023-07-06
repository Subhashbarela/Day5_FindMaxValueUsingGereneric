using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueUsingGeneric
{
    internal class FindMaxUsingArray
    {
        public class MaximumValue<T> where T : IComparable
        {

            T[] values;
            public MaximumValue(T[] values)
            {
                this.values = values;
            }
            public T[] SortArray(T[] values)
            {
                Array.Sort(values);
                return values;  //Aftre sorting array is return 
            }
            public T MaxValue(params T[] values)
            {
                var sorted_value = SortArray(values); //Access sorted array from SortArray Method and return max value

                return sorted_value[sorted_value.Length - 1];
            }
            public void PrintMaxValue()
            {
                var max = MaxValue(this.values); //Access max value from MaxValue Method
                Console.WriteLine("Maximum value is : " + max);
            }

        }
    }
}
