using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroEntero_poo
{
    class Vector
    {
        const int MAX_LENGTH = 200;
        private int[] numbers;
        private int number;
        // Constructor
        public Vector()
        {
            number = 0;
            numbers = new int[MAX_LENGTH];
        }
        // Methods
        public void SetNumber(int value, int max, int min)
        {
            int index;
            number = value;
            Random numRandom = new Random();
            for (index = 1; index <= number; index++)
                numbers[index] = numRandom.Next(min, max);
        }

        public string GetNumbers()
        {
            string result = "";
            int index;
            for (index = 1; index <= number; index++)
            {
                if (index == number) result = result + numbers[index];
                else result = result = result + numbers[index] + "  |  ";
            }
            return result;
        }

        public void SelectPairs(ref Vector objResult)
        {
            IntegerNumber objIntNumber = new IntegerNumber();
            int index;
            objResult.number = 0;
            for (index = 1; index <= number; index++)
            {
                objIntNumber.setNumber(numbers[index]);
                if (objIntNumber.isEven())
                {
                    objResult.number++;
                    objResult.numbers[objResult.number] = numbers[index];
                }
            }
        }

        public void SelectMultiple(ref Vector vectorResult, int multiple)
        {
            IntegerNumber objIntNumber = new IntegerNumber();
            int index;
            vectorResult.number = 0;
            for (index = 1; index <= number; index++)
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
            for (index = 1; index <= number; index++)
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
            for (index = 1; index <= number; index++)
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
            for (index = 1; index <= number; index++)
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
            for (index = 1; index <= number; index++)
            {
                objIntNumber.setNumber(numbers[index]);
                if (objIntNumber.checkIfIsFibonacci(0, 1))
                {
                    vectorResult.number++;
                    vectorResult.numbers[vectorResult.number] = numbers[index];
                }
            }
        }
    }
}
