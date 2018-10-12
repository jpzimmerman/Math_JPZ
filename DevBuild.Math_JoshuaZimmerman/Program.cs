using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBuild.Utilities;

namespace DevBuild.Math_JoshuaZimmerman
{
    class Program
    {
        private const int MULTIPLICATION_TABLE_MAX_SIZE = 12;

        static void Main(string[] args)
        {
            int userNumber = 0;
            YesNoAnswer userAnswer = YesNoAnswer.AnswerNotGiven;

            Console.Write(  "***********************************************************\n" +
                            "*          Dev.Build(2.0) - Multiplication Tables         *\n" +
                            "***********************************************************\n\n");
            while (true)
            {
                //Prompt user to enter number, verify that input was indeed a number
                Console.Write("Please enter a number: ");
                while (!int.TryParse(Console.ReadLine(), out userNumber))
                {
                    Console.Write("Please enter a number: ");
                }

                //Send user's number to PrintMultiplicationTable for display of multiples
                PrintMultiplicationTable(userNumber);

                //ask the user if they would like to enter another number
                userAnswer = UserInput.GetYesOrNoAnswer("Would you like to enter another number? ");
                switch (userAnswer)
                {
                    case YesNoAnswer.Yes: userAnswer = YesNoAnswer.AnswerNotGiven; continue;
                    case YesNoAnswer.No: userAnswer = YesNoAnswer.AnswerNotGiven; return;
                }
            }
        }

        static void PrintMultiplicationTable(int factor)
        {
            //Print multiplication table header
            Console.WriteLine("\n");
            Console.WriteLine("|      {0}".PadLeft(17), factor);
            Console.WriteLine("-------|-------");

            for (int i = 0; i <= MULTIPLICATION_TABLE_MAX_SIZE; i++)
            {
                int multiple = factor * i;
                Console.WriteLine(i.ToString().PadLeft(3) + "|".PadLeft(5) + multiple.ToString().PadLeft(7));
            }
            Console.WriteLine("\n");
        }

    }
}
