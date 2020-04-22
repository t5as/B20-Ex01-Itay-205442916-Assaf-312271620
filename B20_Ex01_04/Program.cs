using System;
using System.Collections.Generic;
using System.Text;

namespace B20_Ex01_04
{
    class Program
    {
        public static void Main()
        {
            string strInputString = getInputString();
            int intInputNumber = isStringANumber(strInputString);
            bool isInputStringValid = isEightLengthString(strInputString)
                                      && (intInputNumber != 0 || isStringEnglishChars(strInputString));
            if(!isInputStringValid)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                if (isPalindrome(strInputString))
                {
                    Console.WriteLine("The string " + strInputString + " is a palindrome");
                }
                else
                {
                    Console.WriteLine("The string " + strInputString + " is not a palindrome");
                }
 
                if (intInputNumber != 0)
                {
                    if(isNumberSplitIn5(intInputNumber))
                    {
                        Console.WriteLine("The number " + intInputNumber + " splits in 5");
                    }
                    else
                    {
                        Console.WriteLine("The number " + intInputNumber + " does not split in 5");
                    }
                        
                }
                else
                { 
                    Console.WriteLine("The string " + strInputString + " contains " + countNumberOfUppercaseLetters(strInputString) + " uppercase letters");
                }
            }

        }

        private static string getInputString()
        {
            Console.WriteLine("Please enter a 8 chars string: ");
            string strInputNumber = Console.ReadLine();
            return strInputNumber;
        }

        private static bool isEightLengthString(string io_strInputString)
        {
            return io_strInputString.Length == 8;
        }

        private static int isStringANumber(string io_strInputString)
        {
            int i_inputNumber = 0;
            int.TryParse(io_strInputString, out i_inputNumber);
            return i_inputNumber;
        }

        private static bool isStringEnglishChars(string io_strInputString)
        {
            foreach (char i_char in io_strInputString)
            {
                if (!Char.IsLetter(i_char))
                    return false;
            }
            return true;
        }

        private static bool isPalindrome(string io_strInputString)
        {
            if(io_strInputString.Length <= 1)
            {
                return true;
            }
            else
            {
                if(io_strInputString[0] != io_strInputString[io_strInputString.Length - 1])
                {
                    return false;
                }

                else
                {
                    return isPalindrome(io_strInputString.Substring(1, io_strInputString.Length - 2));
                }
            }

        }

        private static bool isNumberSplitIn5(int io_inputNumber)
        {
            return io_inputNumber % 5 == 0;
        }

        private static int countNumberOfUppercaseLetters(string io_strInputString)
        {
            int uppercaseLettersCounter = 0;
            foreach (char i_char in io_strInputString)
            {
                if (Char.IsUpper(i_char))
                    uppercaseLettersCounter++;
            }
            return uppercaseLettersCounter;
        }

    }
}
