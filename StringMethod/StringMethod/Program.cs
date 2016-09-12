using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 90, 100, 82, 89, 55 };
            //string gradNumbers = "90,100,82,89,55";
            string letters = "dfskjdjkcek";
            //Console.WriteLine(grades.Average());
            Methods method = new Methods();
            method.averageNumbers(grades);
            //method.averageNums(gradNumbers);
            method.orderLettersCounted(letters);
            Console.ReadLine();

           
        }
    }
}
