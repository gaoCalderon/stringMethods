using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    class Methods
    {
        

        

        public void averageNumbers(int[] array)
        {
            int size = array.Length;
            int sum = array.Aggregate((a, b) => b + a);
            double average = array.Average(x => sum / size);
            Console.WriteLine(average);
        }

        //public void averageNums(string numbers)
        //{
        //    int size = numbers.Length;
        //    int sum = numbers.Aggregate((a, b) => b + a);
        //    double average = numbers.Average(x => sum / size);
        //    Console.WriteLine(average);
        //}


        public string orderLettersCounted(string s)
        {
            char[] a = s.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }
       

    }
}
