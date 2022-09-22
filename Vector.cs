using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroEntero_poo
{
    class Vector
    {
        private int[] numbers;
        private int number;
        // Constructor
        public Vector()
        {
            number = 0;
        }
        // Methods
        public void SetNumber(int value, int max, int min)
        {
            numbers = new int[value];
            int index;
            number = value;
            Random numRandom = new Random();
            for (index = 0; index < value; index++)
                numbers[index] = numRandom.Next(min, max);
        }

        public string GetNumbers()
        {
            string result = "";
            int index;
            for (index = 0; index < number; index++)
            {
                if (index == number) result = result + numbers[index];
                else result = result = result + numbers[index] + "  |  ";
            }
            return result;
        }

        public void SelectPairs(ref Vector vectorResult)
        {
            IntegerNumber objIntNumber = new IntegerNumber();
            int index;
            vectorResult.number = 0;
            for (index = 0; index < number; index++)
            {
                objIntNumber.setNumber(numbers[index]);
                if (objIntNumber.isEven())
                {
                    vectorResult.number++;
                    vectorResult.numbers[vectorResult.number] = numbers[index];
                }
            }
        }

        public void SelectMultiple(ref Vector vectorResult, int multiple)
        {
            IntegerNumber objIntNumber = new IntegerNumber();
            int index;
            vectorResult.number = 0;
            for (index = 0; index < number; index++)
            {
                objIntNumber.setNumber(numbers[index]);
                if (objIntNumber.isMultiple(multiple))
                {
                    vectorResult.number++;
                    vectorResult.numbers[vectorResult.number] = numbers[index];
                }
            }
        }

        public void SelectSubMultiple(ref Vector vectorResult)
        {
            IntegerNumber objIntNumber = new IntegerNumber();
            int index;
            vectorResult.number = 0;
            objIntNumber.setNumber(number);
            for (index = 0; index < number; index++)
            {
                if (objIntNumber.isMultiple(numbers[index]))
                {
                    vectorResult.number++;
                    vectorResult.numbers[vectorResult.number] = numbers[index];
                }
            }
        }

        public void SelectPrimes(ref Vector vectorResult)
        {
            int index;
            IntegerNumber objIntNumber = new IntegerNumber();
            vectorResult.number = 0;
            for (index = 0; index < number; index++)
            {
                objIntNumber.setNumber(numbers[index]);
                if (objIntNumber.isPrime())
                {
                    vectorResult.number++;
                    vectorResult.numbers[vectorResult.number] = numbers[index];
                }
            }
        }

        public void SelectPalindrome(ref Vector vectorResult)
        {
            int index;
            IntegerNumber objIntNumber = new IntegerNumber();
            vectorResult.number = 0;
            for (index = 0; index < number; index++)
            {
                objIntNumber.setNumber(numbers[index]);
                if (objIntNumber.isPalindrome())
                {
                    vectorResult.number++;
                    vectorResult.numbers[vectorResult.number] = numbers[index];
                }
            }
        }

        public void SelectFibonacci(ref Vector vectorResult)
        {
            int index;
            IntegerNumber objIntNumber = new IntegerNumber();
            vectorResult.number = 0;
            for (index = 0; index < number; index++)
            {
                objIntNumber.setNumber(numbers[index]);
                if (objIntNumber.checkIfIsFibonacci(0, 1))
                {
                    vectorResult.number++;
                    vectorResult.numbers[vectorResult.number] = numbers[index];
                }
            }
        }

        // TODO: Use this method to resuable code - clean code
        private void SelectMethod(ref Vector vectorResult, int index)
        {
            vectorResult.number++;
            vectorResult.numbers[vectorResult.number] = numbers[index];
        }

        public void OrderMethod()
        {
            Array.Sort(numbers);
        }
    }
}
