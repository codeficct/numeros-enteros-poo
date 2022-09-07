using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Property
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods
        public void setNumber(int value)
        {
            number = value;
        }

        public int getNumber()
        {
            return number;
        }

        public bool isEven()
        {
            return number % 2 == 0;
        }

        public bool isMultiple(int multiple)
        {
            return number % multiple == 0;
        }

        public bool isSubMultiple()
        {
            int index = 0;
            bool result = false;
            for (index = 1; index < number; index++)
            {
                if (isMultiple(index))
                {
                    result = true;
                }
            }
            return result;
        }

        public bool isPrime()
        {
            bool result = false;
            int r;
            if (number > 1)
            {
                int index = 1;
                do
                {
                    index++;
                    r = number % index;
                } while (r != 0);
                result = (number == 1);
            }
            return result;
        }

        public int reverseInteger()
        {
            int num, digit, result;
            result = 0;
            num = number;
            digit = num % 10;
            result = (result * 10) + digit;
            num = num / 10;
            return result;
        }

        public bool isPalindrome()
        {
            return reverseInteger() == number;
        }

        public bool checkIfIsFibonacci()
        {
            int a = 0, b = 0, c, index;
            bool result = false;

            for (index = 0; index <= number; index++)
            {
                c = a + b;
                if (c == number) result = true;
                a = b; b = c;
            }

            return result;
        }

        public double getFactorial()
        {
            double result = 1;
            int index;
            if (number != 0)
            {
                for (index = Math.Abs(number); index > 1; index--)
                {
                    result = result * index;
                }
                if (number < 0) result = -result;
            }
            return result;
        }

        public bool isOrder()
        {
            int numOrder = 0;
            int[] numArray = new int[number.ToString().Length];
            int digit, index, clone = number;
            for (index = 0; index < number; index++)
            {
                digit = clone % 10;
                numArray[index] = digit;
                clone = clone / 10;
            }

            Array.Sort(numArray);

            for (int i = 0; i < numArray.Length; i++)
            {
                numOrder = numOrder * 10 + numArray[index];
            }
            return number == numOrder;
        }
    }
}
