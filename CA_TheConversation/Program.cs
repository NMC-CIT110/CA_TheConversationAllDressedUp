using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TheConversationAllDressedUp
{

    // *************************************************************
    // Application:     The Conversation All Dressed Up
    // Author:          Velis, John E
    // Description:     An application that has a conversation with the user
    //                  about getting a loan. Console properties are controlled.
    // Date Created:    5/20/2019
    // Date Revised:    7/7/2019
    // *************************************************************

    class Program
    {
        static void Main(string[] args)
        {
            //
            // constants
            // 
            ConsoleColor openingClosingScreenBackground = ConsoleColor.Gray;
            ConsoleColor openingClosingScreenForeground = ConsoleColor.DarkRed;
            ConsoleColor appScreenBackground = ConsoleColor.White;
            ConsoleColor appScreenForeground = ConsoleColor.DarkBlue;

            //
            // variables
            //
            string userName;
            string bankChoice;
            string typeOfLoan;
            string userResponse;
            double principle;
            double interestRate;
            int numberOfYears;


            //
            // *** New Screen ***
            // set background colors, foreground colors, and clear screen
            //
            Console.BackgroundColor = openingClosingScreenBackground;
            Console.ForegroundColor = openingClosingScreenForeground;
            Console.Clear();

            //
            // display a welcome screen
            // 
            Console.WriteLine();
            Console.WriteLine("\t\tThe Loan Consultant");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();

            //
            // *** New Screen ***
            // set background colors, foreground colors, and clear screen
            //
            Console.BackgroundColor = appScreenBackground;
            Console.ForegroundColor = appScreenForeground;
            Console.Clear();

            //
            // enter conversation with user
            //
            Console.WriteLine();
            Console.WriteLine(" Hello!");
            Console.WriteLine(" This application is designed to calculate monthly loan payments.");

            //
            // get their name and echo it back
            //
            Console.WriteLine();
            Console.Write(" What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine(" It is nice to meet you " + userName + ".");
            //Console.WriteLine("It is nice to meet you {0}.", userName);
            //Console.WriteLine($"It is nice to meet you {userName}.");

            //
            // determine if the user is looking for a loan
            //
            Console.WriteLine();
            Console.Write($" Are you interested in getting a loan {userName}?");
            userResponse = Console.ReadLine();

            //
            // *** New Screen ***
            // clear screen
            //
            Console.Clear();

            //
            // get more information if the user is looking for a loan
            //
            if (userResponse == "yes")
            {
                //
                // get user's favorite ski
                //
                Console.WriteLine();
                Console.WriteLine(" Well you have come to the right place.");
                Console.WriteLine();
                Console.WriteLine(" I will need to get some more information from you and then I can calculate your monthly payment.");

                //
                // *** New Screen ***
                // clear screen
                //
                Console.Clear();

                //
                // get user ski info
                //
                Console.WriteLine();
                Console.Write(" What is the name of the bank you will applying to for the loan?");
                bankChoice = Console.ReadLine();
                Console.WriteLine(" Very good {0}, you will be getting a loan from {1}.", userName, bankChoice);

                //
                // get the user's type of loan
                //
                Console.WriteLine();
                Console.WriteLine(" Please tell me the type of loan your are seeking so that I can determine the interest rate.");
                Console.Write("  \"House\"  \"Vehicle\"  \"College\"  \"Personal\"");
                typeOfLoan = Console.ReadLine();

                //
                // provide feedback on the type of skiing
                //
                Console.WriteLine();
                if (typeOfLoan == "downhill")
                {
                    Console.WriteLine("I have downhill skied for most of my life, but gave it up last year.");
                    Console.WriteLine($"I hear the {favoriteArea} is a great place to ski {userName}.");
                }
                else if (typeOfLoan == "back country")
                {
                    Console.WriteLine("I spend most of my time skiing now in back country.");
                    Console.WriteLine($"Well {userName}, I am not sure I have skied at {favoriteArea}. I will have to give it a try.");
                }
                else // user's response was not valid
                {
                    Console.WriteLine("I am afraid I don't recognize that type of skiing.");
                }

                //
                // thank the user and say good bye
                //
                Console.WriteLine();
                Console.WriteLine($"{userName}, it has been great getting learn more about your skiing interests.");
                Console.WriteLine("Have a nice day.");
            }
            else // user does not want a loan
            {
                Console.WriteLine();
                Console.WriteLine($" I am sorry you are not looking for a loan {userName}, but this application ");
                Console.WriteLine(" is for people interested in the monthly payments for a specific loan.");
                Console.WriteLine(" Have a nice day.");
            }

            //
            // display a prompt to exit the application
            //
            Console.WriteLine();
            Console.WriteLine(" Press any key to continue.");
            Console.ReadKey();

            //
            // *** New Screen ***
            // set background colors, foreground colors, and clear screen
            //
            Console.BackgroundColor = openingClosingScreenBackground;
            Console.ForegroundColor = openingClosingScreenForeground;
            Console.Clear();

            //
            // display a closing screen
            // 
            Console.WriteLine();
            Console.WriteLine("\t\tThank You for Your Interest in Our Application");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to exit..");
            Console.ReadKey();
        }
    }
}
