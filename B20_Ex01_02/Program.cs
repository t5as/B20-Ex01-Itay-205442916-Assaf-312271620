using System;


namespace B20_Ex01_02
{
    public class Program
    {
        public static void Main()
        {
            hourGlass(5, 5, -2);
        }

        public static void hourGlass(int i_maxNumberOfStars, int i_numberOfStarsToPrint, int i_jumpToNextStep)
        {
            string strLineToDraw = "";
            int numberOfSpaces = (i_maxNumberOfStars - i_numberOfStarsToPrint) / 2;
            strLineToDraw = strLineToDraw + strLineOfSpaces(numberOfSpaces, "") + strLineOfStars(i_numberOfStarsToPrint, "") + strLineOfSpaces(numberOfSpaces, "");
            Console.WriteLine(strLineToDraw);
            if (i_numberOfStarsToPrint != i_maxNumberOfStars || i_jumpToNextStep < 0)
            {
                if (i_numberOfStarsToPrint == 1)
                {
                    i_jumpToNextStep *= -1;
                }
                hourGlass(i_maxNumberOfStars, i_numberOfStarsToPrint + i_jumpToNextStep, i_jumpToNextStep);
            }
        }

        private static string strLineOfStars(int i_numberOfStarsToDraw, string io_starLine)
        {
            if (i_numberOfStarsToDraw == 0)
            {
                return io_starLine;
            }
            else
            {
                io_starLine = io_starLine + "*";
                return strLineOfStars(i_numberOfStarsToDraw - 1, io_starLine);
            }
        }

        private static string strLineOfSpaces(int i_numberOfSpacesToDraw, string io_spaceLine)
        {
            if (i_numberOfSpacesToDraw == 0)
            {
                return io_spaceLine;
            }
            else
            {
                io_spaceLine = io_spaceLine + " ";
                return strLineOfSpaces(i_numberOfSpacesToDraw - 1, io_spaceLine);
            }
        }

    }
}
