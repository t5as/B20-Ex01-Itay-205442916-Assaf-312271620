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
                bool isInputNumberValid = IsNineLengthInput(strInputNumber) && isBinaryNumber(strInputNumber);

                while (!isInputNumberValid)
                {
                    Console.WriteLine("Invalid Input");
                    strInputNumber = getInputNumber();
                    isInputNumberValid = IsNineLengthInput(strInputNumber) && isBinaryNumber(strInputNumber);
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

                biggestInputNumber = Math.Max(inputNumber, smallestInputNumber);

                if (i == 0)
                {
                    smallestInputNumber = inputNumber;
                }
                
                smallestInputNumber = Math.Min(inputNumber, smallestInputNumber);
            }

            string msg = string.Format(
@"The average number of 0's in the three numbers is: {0}
The average number of 1's in the three numbers is: {1}
The amount of power of 2's numbers is: {2}
The amount of numbers with ascending digits is: {3}
The biggest number is: {4} 
The smallest number is: {5}", 
sumOfZeros / 3, 
sumOfOnes / 3,
countNumberOfPowersOfTwo,
countAscendingDigitsNumbers,
biggestInputNumber,
smallestInputNumber);
            Console.WriteLine(msg);
        }

        private static string getInputNumber()
        {
            Console.WriteLine("Please enter a 9 length positive binary number: ");
            string strInputNumber = Console.ReadLine();
            
            return strInputNumber;
        }

        public static bool IsNineLengthInput(string i_strInputNumber)
        {
            return i_strInputNumber.Length == 9;
        }

        private static int[] getNumberOfZerosAndOnes(string i_strInputNumber)
        {
            int numberOfZeros = 0;
            int numberOfOnes = 0;

            for (int i = 0; i < i_strInputNumber.Length; i++)
            {
                if (i_strInputNumber[i] == '0')
                {
                    numberOfZeros++;
                }
                else if (i_strInputNumber[i] == '1')
                {
                    numberOfOnes++;
                }
            }

            int[] numberOfZerosAndOnes = { numberOfZeros, numberOfOnes };
            
            return numberOfZerosAndOnes;
        }

        private static bool isBinaryNumber(string i_strInputNumber)
        {
            int[] numberOfZerosAndOnes = getNumberOfZerosAndOnes(i_strInputNumber);
            
            return numberOfZerosAndOnes[0] + numberOfZerosAndOnes[1] == i_strInputNumber.Length;
        }

        private static int binaryToDecimal(int i_inputNumber)
        {
            double baseCount = 0;
            int decimalValue = 0;
            string strToBinary = i_inputNumber.ToString();

            for (int i = strToBinary.Length - 1; i >= 0; i--)
            {
                decimalValue += int.Parse(strToBinary[i] + string.Empty) * (int)Math.Pow(2, baseCount);
                baseCount++;
            }

            return decimalValue;
        }

        private static bool areDigitsAscending(int i_inputNumber)
        {
            bool areDigitsAscending = true;
            string strDecimalInputNumber = i_inputNumber.ToString();

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
