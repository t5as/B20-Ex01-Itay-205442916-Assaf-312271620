using System;

namespace B20_Ex01_05
{
    public class Program
    {
        public static void Main()
        {
            string strInputNumber = getInputNumber();
            int inputNumber = 0;
            bool isStringNumber = int.TryParse(strInputNumber, out inputNumber);

            if (B20_Ex01_01.Program.IsNineLengthInput(strInputNumber) && inputNumber != 0)
            {
                string msg = string.Format(
@"Hello,
    The Biggest digit in the number is {0} and the smallest digit is {1}. 
    In addition, the number of divided by three digits is {2} and the number 
    of digits that are bigger than the units digit is {3}",
getBiggestDigit(inputNumber),
getSmallestDigit(inputNumber),
numberOfDividedByThreeDigits(inputNumber),
numberOfDigitsBiggerThanUnit(inputNumber));
                Console.WriteLine(msg);
            }
        }

        private static string getInputNumber()
        {
            Console.WriteLine("Please enter a 9 length positive number: ");
            string strInputNumber = Console.ReadLine();
            
            return strInputNumber;
        }

        private static int getBiggestDigit(int i_inputNumber)
        {
            int maxNumber = 0;
            string strDecimalInputNumber = i_inputNumber.ToString();

            for (int i = 0; i < strDecimalInputNumber.Length; i++)
            {
                int digitToCheck = int.Parse(strDecimalInputNumber[i] + string.Empty);
                maxNumber = Math.Max(digitToCheck, maxNumber);
            }

            return maxNumber;
        }

        private static int getSmallestDigit(int i_inputNumber)
        {
            int minNumber = 9;
            string strDecimalInputNumber = i_inputNumber.ToString();

            for (int i = 0; i < strDecimalInputNumber.Length; i++)
            {
                int digitToCheck = int.Parse(strDecimalInputNumber[i] + string.Empty);
                minNumber = Math.Min(digitToCheck, minNumber);
            }

            return minNumber;
        }

        private static int numberOfDividedByThreeDigits(int i_inputNumber)
        {
            int countOfDividedByThreeDigits = 0;
            string strDecimalInputNumber = i_inputNumber.ToString();

            for (int i = 0; i < strDecimalInputNumber.Length; i++)
            {
                int digitToCheck = int.Parse(strDecimalInputNumber[i] + string.Empty);

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
            int unitsDigit = int.Parse(strDecimalInputNumber[strDecimalInputNumber.Length - 1] + string.Empty);

            for (int i = strDecimalInputNumber.Length - 2; i >= 0; i--)
            {
                if (int.Parse(strDecimalInputNumber[i] + string.Empty) > unitsDigit)
                {
                    countNumberOfDigits++;
                }
            }

            return countNumberOfDigits;
        }
    }
}
