using System;

namespace B20_Ex01_01
{
    public class Program
    {
        public static void Main()
        {

            int sumOfZeros = 0;
            int sumOfOnes = 0;
            int countAscendingDigitsNumbers = 0;
            int countNumberOfPowersOfTwo = 0;
            int biggestInputNumber = 0;
            int smallestInputNumber = 0;
            for (int i = 0; i < 3; i++)
            {
                string strInputNumber = getInputNumber();
                bool isInputNumberValid = isNineLengthNumber(strInputNumber) && isBinaryNumber(strInputNumber);
                while (!isInputNumberValid)
                {
                    Console.WriteLine("Invalid Input");
                    strInputNumber = getInputNumber();
                    isInputNumberValid = isNineLengthNumber(strInputNumber) && isBinaryNumber(strInputNumber);
                }

                int inputNumber = binaryToDecimal(int.Parse(strInputNumber));
                Console.WriteLine("The decimal representation of our number: " + inputNumber);
                sumOfZeros += getNumberOfZerosAndOnes(strInputNumber)[0];
                sumOfOnes += getNumberOfZerosAndOnes(strInputNumber)[1];

                if (getNumberOfZerosAndOnes(strInputNumber)[1] == 1)
                {
                    countNumberOfPowersOfTwo++;
                }

                if (areDigitsAscending(inputNumber))
                {
                    countAscendingDigitsNumbers++;
                }

                if (inputNumber > biggestInputNumber)
                {
                    biggestInputNumber = inputNumber;
                }
                if (i == 0 || inputNumber < smallestInputNumber)
                {
                    smallestInputNumber = inputNumber;
                }

            }
            Console.WriteLine("The average number of 0's in the three numbers is: " + sumOfZeros / 3);
            Console.WriteLine("The average number of 1's in the three numbers is: " + sumOfOnes / 3);
            Console.WriteLine("The amount of power of 2's numbers is: " + countNumberOfPowersOfTwo);
            Console.WriteLine("The amount of numbers with ascending digits is: " + countAscendingDigitsNumbers);
            Console.WriteLine("The biggest number is: " + biggestInputNumber);
            Console.WriteLine("The smallest number is: " + smallestInputNumber);
        }

        private static string getInputNumber()
        {
            Console.WriteLine("Please enter a 9 length positive binary number: ");
            string strInputNumber = Console.ReadLine();
            return strInputNumber;
        }

        private static bool isNineLengthNumber(string io_strInputNumber)
        {
            return io_strInputNumber.Length == 9;
        }

        private static int[] getNumberOfZerosAndOnes(string io_strInputNumber)
        {
            int numberOfZeros = 0;
            int numberOfOnes = 0;
            for (int i = 0; i < io_strInputNumber.Length; i++)
            {
                if (io_strInputNumber[i] == '0')
                {
                    numberOfZeros++;
                }
                else if (io_strInputNumber[i] == '1')
                {
                    numberOfOnes++;
                }
            }
            int[] numberOfZerosAndOnes = { numberOfZeros, numberOfOnes };
            return numberOfZerosAndOnes;
        }


        private static bool isBinaryNumber(string io_strInputNumber)
        {
            int[] numberOfZerosAndOnes = getNumberOfZerosAndOnes(io_strInputNumber);
            return (numberOfZerosAndOnes[0] + numberOfZerosAndOnes[1] == io_strInputNumber.Length);

        }

        private static int binaryToDecimal(int io_inputNumber)
        {
            double baseCount = 0;
            int decimalValue = 0;
            string strToBinary = io_inputNumber.ToString();
            for (int i = strToBinary.Length - 1; i >= 0; i--)
            {
                decimalValue += int.Parse(strToBinary[i] + "") * (int)Math.Pow(2, baseCount);
                baseCount++;
            }
            return decimalValue;
        }

        private static bool areDigitsAscending(int io_inputNumber)
        {
            bool areDigitsAscending = true;
            string strDecimalInputNumber = io_inputNumber.ToString();
            for (int i = 0; i < strDecimalInputNumber.Length - 1; i++)
            {
                if (strDecimalInputNumber[i] >= strDecimalInputNumber[i + 1])
                {
                    areDigitsAscending = false;
                }
            }

            return areDigitsAscending;
        }
    }
}
