using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give me the first number : ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please five me the second Number : ");
            int secondNumber = int.Parse(Console.ReadLine());
            CalculationsClass twoNumbers = new CalculationsClass(firstNumber, secondNumber);
        }
    }
}
