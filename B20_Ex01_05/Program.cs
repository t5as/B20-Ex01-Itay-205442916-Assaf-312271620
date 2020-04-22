using System;
using System.Collections.Generic;
using System.Text;

namespace B20_Ex01_05
{
    class Program
    {
        public static void Main()
        {
            string strInputNumber = B20_Ex01_01.Program.getInputNumber();
            int inputNumber = B20_Ex01_04.Program.isStringANumber(strInputNumber);
            if (B20_Ex01_01.Program.isNineLengthInput(strInputNumber) && inputNumber != 0)
            {
                int[] args = new int[4];
                args[0] = getBiggestDigit(inputNumber);
                args[1] = getSmallestDigit(inputNumber);
                args[2] = numberOfDividedByThreeDigits(inputNumber);
                args[3] = numberOfDigitsBiggerThanUnit(inputNumber);
                string msg = string.Format(
@"Hello,
    The Biggest digit in the number is {0} and the smallest digit is {1}. 
    In addition, the number of divided by three digits is {2} and the number 
    of digits that are bigger than the units digit is {3}", args[0], args[1], args[2], args[3]);
                Console.WriteLine(msg);
            }
        }

        private static int getBiggestDigit(int i_inputNumber)
        {
            int maxNumber = 0;
            string strDecimalInputNumber = i_inputNumber.ToString();
            for (int i = 0; i < strDecimalInputNumber.Length; i++)
            {
                int digitToCheck = int.Parse(strDecimalInputNumber[i] + "");
                if (digitToCheck > maxNumber)
                {
                    maxNumber = digitToCheck;
                }
            }
            return maxNumber;
        }

        private static int getSmallestDigit(int i_inputNumber)
        {
            int minNumber = 9;
            string strDecimalInputNumber = i_inputNumber.ToString();
            for (int i = 0; i < strDecimalInputNumber.Length; i++)
            {
                int digitToCheck = int.Parse(strDecimalInputNumber[i] + "");
                if (digitToCheck < minNumber)
                {
                    minNumber = digitToCheck;
                }
            }
            return minNumber;
        }

        private static int numberOfDividedByThreeDigits(int i_inputNumber)
        {
            int countOfDividedByThreeDigits = 0;
            string strDecimalInputNumber = i_inputNumber.ToString();
            for (int i = 0; i < strDecimalInputNumber.Length; i++)
            {
                int digitToCheck = int.Parse(strDecimalInputNumber[i] + "");
                if (digitToCheck % 3 == 0)
                {
                    countOfDividedByThreeDigits++;
                }
            }
            return countOfDividedByThreeDigits;
        }

        private static int numberOfDigitsBiggerThanUnit(int i_inputNumber)
        {
            int countNumberOfDigits = 0;
            string strDecimalInputNumber = i_inputNumber.ToString();
            int unitsDigit = int.Parse(strDecimalInputNumber[strDecimalInputNumber.Length - 1] + "");
            for (int i = strDecimalInputNumber.Length - 2; i >= 0; i--)
            {
                if (int.Parse(strDecimalInputNumber[i] + "") > unitsDigit)
                {
                    countNumberOfDigits++;
                }
            }
            return countNumberOfDigits;
        }
    }
}
