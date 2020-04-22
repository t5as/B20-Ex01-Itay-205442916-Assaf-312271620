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
            bool isInputStringValid = isEightLengthString(strInputString)
                                      && (IsStringANumber(strInputString) || isStringEnglishChars(strInputString));

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
 
                if (IsStringANumber(strInputString))
                {
                    int intInput = int.Parse(strInputString);

                    if(isNumberSplitIn5(intInput))
                    {
                        Console.WriteLine("The number " + intInput + " splits in 5");
                    }
                    else
                    {
                        Console.WriteLine("The number " + intInput + " does not split in 5");
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

        public static bool IsStringANumber(string io_strInputString)
        {
            const bool v_OnlyDigits = true;

            foreach (char i_char in io_strInputString)
            {
                if (!char.IsDigit(i_char))
                {
                    return !v_OnlyDigits;
                }
            }

            return v_OnlyDigits;
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
