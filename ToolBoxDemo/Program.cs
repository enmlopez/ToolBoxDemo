using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class Program
    {

        //access modifier --  Main takes an array of string called args
        static void Main(string[] args) //Main Method - program.exe file, aka executable /entry point. Double click on to start program
        {
            Console.WriteLine("Welcome to your Tool Box!\n");
            Console.WriteLine(" You can either hit \"Y\" then ENTER to continue \n\n OR \n\n hit \"N\" then ENTER to Clear the Console and Continue");

            string userResponse = Console.ReadLine().ToUpper();

            if (userResponse == "Y")
            {
                KeyToContinue();
            }
            else if (userResponse == "N")
            {
                ClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure friend, but I'm gonna close the program when you hit ENTER");
            }
           
           
            Console.ReadLine();

            // S - single responsibility issue (S.O.L.I.D.)

            //Functions are methods written outside of a custom class
            //Methods are functions written inside of a custom class


            //Functions below this
            void KeyToContinue()
            {
            Console.WriteLine("Hit ENTER to continue on with the code...");
            Console.ReadLine();
            }

            void ClearConsole()
            {
            Console.Clear();
            Console.WriteLine("Congratulations! You've cleared the Console!...hit ENTER to close the program");
            }
            
            void KeyToContinueWithClearConsole()
            {
                KeyToContinue();
                ClearConsole();
            }


        }
    }
}
