using System;

namespace B20_Ex01_04
{
    public class Program
    {
        public static void Main()
        {
            string strInputString = getInputString();
            string notPalindrome = " ";
            string numberOrEnglish = string.Empty;
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
                    notPalindrome = " not ";
                }
 
                if (isStringNumber)
                {
                    string numberNotDividedBy5 = " ";

                    if (!isNumberSplitIn5(intInput))
                    {
                        numberNotDividedBy5 = " not ";
                    }

                    numberOrEnglish = string.Format(
                        @"The string is a number that is{0}divided by 5", numberNotDividedBy5);
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
notPalindrome, 
numberOrEnglish));
            }
        }

        private static string getInputString()
        {
            Console.WriteLine("Please enter a 8 chars string: ");
            string strInputNumber = Console.ReadLine();
            
            return strInputNumber;
        }

        private static bool isEightLengthString(string i_strInputString)
        {
            return i_strInputString.Length == 8;
        }

        private static bool isStringEnglishChars(string i_strInputString)
        {
            bool isOnlyLetters = true;

            foreach (char currentChar in i_strInputString)
            {
                if(!char.IsLetter(currentChar))
                {
                    return !isOnlyLetters;
                }
            }

            return isOnlyLetters;
        }

        private static bool isPalindrome(string i_strInputString)
        {
            bool isSubstringPalindrome = true;
            int substringLength = i_strInputString.Length;

            if (substringLength <= 1)
            {
                return isSubstringPalindrome;
            }
            else
            {
                if(i_strInputString[0] != i_strInputString[substringLength - 1])
                {
                    return !isSubstringPalindrome;
                }
                else
                {
                    return isPalindrome(i_strInputString.Substring(1, substringLength - 2));
                }
            }
        }

        private static bool isNumberSplitIn5(int i_inputNumber)
        {
            return i_inputNumber % 5 == 0;
        }

        private static int countNumberOfUppercaseLetters(string i_strInputString)
        {
            int uppercaseLettersCounter = 0;

            foreach (char currentChar in i_strInputString)
            {
                if(char.IsUpper(currentChar))
                {
                    uppercaseLettersCounter++;
                }
            }

            return uppercaseLettersCounter;
        }
    }
}
