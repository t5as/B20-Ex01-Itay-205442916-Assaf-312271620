using System;
using System.Collections.Generic;
using System.Text;

namespace B20_Ex01_04
{
    public class Program
    {
        public static void Main()
        {
            string strInputString = getInputString();
            string palindrome = " ";
            string numberOrEnglish = "";
            int intInput = 0;
            bool isStringNumber = int.TryParse(strInputString, out intInput);
            bool isInputStringValid = isEightLengthString(strInputString)
                                      && (isStringNumber || isStringEnglishChars(strInputString));
            
            if (!isInputStringValid)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                if (!isPalindrome(strInputString))
                {
                    palindrome = " not ";
                }
 
                if (isStringNumber)
                {
                    string numberSplit = " ";

                    if (!isNumberSplitIn5(intInput))
                    {
                        numberSplit = " does not ";
                    }

                    numberOrEnglish = string.Format(
                        @"The string is number that{0}split in 5", numberSplit);
                }
                else
                { 
                    numberOrEnglish = string.Format(
                        @"The string is an English string and contains {0} uppercase letters", countNumberOfUppercaseLetters(strInputString));
                }
                
                Console.WriteLine(string.Format(
@"Hello, 
The string is{0}a palindrome. 
{1}.",
                    palindrome, numberOrEnglish));
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

        private static bool isStringEnglishChars(string io_strInputString)
        {
            const bool v_OnlyLetters = true;

            foreach (char i_char in io_strInputString)
            {
                if(!char.IsLetter(i_char))
                {
                    return !v_OnlyLetters;
                }
            }

            return v_OnlyLetters;
        }

        private static bool isPalindrome(string io_strInputString)
        {
            const bool v_SubstringPalindrome = true;
            int substringLength = io_strInputString.Length;

            if (substringLength <= 1)
            {
                return v_SubstringPalindrome;
            }
            else
            {
                if(io_strInputString[0] != io_strInputString[substringLength - 1])
                {
                    return !v_SubstringPalindrome;
                }
                else
                {
                    return isPalindrome(io_strInputString.Substring(1, substringLength - 2));
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
                if(char.IsUpper(i_char))
                {
                    uppercaseLettersCounter++;
                }
            }

            return uppercaseLettersCounter;
        }
    }
}
