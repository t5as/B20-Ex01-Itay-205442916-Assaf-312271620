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
            bool isInputStringValid = isEightLengthString(strInputString) && isBinaryNumber(strInputNumber);

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

        private static bool isStringANumber(string io_strInputString)
        {
            int io_inputNumber = 0;
            return int.TryParse(io_strInputString, out io_inputNumber);
        }

        private static bool isStringEnglish(string io_strInputString)
        {
            foreach (char i_char in io_strInputString)
            {
                if (!Char.IsLetter(i_char))
                    return false;
            }
            return true;
        }

        private static bool isNumberSplitIn5(int io_inputNumber)
        {
            return io_inputNumber % 5 == 0;
        }

    }
}
