using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsApp
{
    class CalculationsClass
    {
        public int firstNumber;
        public int secondNumber;

        public CalculationsClass(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;

            Console.WriteLine($"The Sum of the two numbers is: {Add(firstNumber,secondNumber)}");
            Console.WriteLine($"The Difference of the two numbers is: {Subtract(firstNumber,secondNumber)}");
            Console.WriteLine($"The Product of the two numbers is: {Multiply(firstNumber, secondNumber)}");
            if(secondNumber != 0)
                Console.WriteLine($"The Quotient of the two numbers is: {Divide(firstNumber,secondNumber)}");
            else
                Console.WriteLine($"One does not simply divide by {secondNumber}");
        }

        public int Add(int firstNumber, int secondNumber)
        {
            int sum;
            sum = firstNumber + secondNumber;
            return (sum);
        }
        public int Subtract(int firstNumber, int secondNumber)
        {
            int diff;
            diff = firstNumber - secondNumber;
            return (diff);
        }
        public int Divide(int firstNumber, int secondNumber)
        {
            int div;
            if (secondNumber != 0)
                div = firstNumber / secondNumber;
            else
                div = 0;
            return (div);
        }
        public int Multiply(int firstNumber, int secondNumber)
        {
            int product;
            product = firstNumber * secondNumber;
            return (product);
        }

    }


}
