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
            // screen configurations
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
            double loanPrinciple;
            double loanInterestRate;
            int loanTermMonths;
            double monthlyPayment;


            //
            //      **********************
            //      *   Opening Screen   *
            //      **********************
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //
            Console.CursorVisible = false;
            Console.BackgroundColor = openingClosingScreenBackground;
            Console.ForegroundColor = openingClosingScreenForeground;
            Console.Clear();


            //
            // display a opening screen
            // 
            Console.WriteLine();
            Console.WriteLine("\t\tThe Loan Consultant");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();

            //
            //      ***************************
            //      *   Initial User Screen   *
            //      ***************************
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //
            Console.CursorVisible = true;
            Console.BackgroundColor = appScreenBackground;
            Console.ForegroundColor = appScreenForeground;
            Console.Clear();

            //
            // greet the user
            //
            Console.WriteLine();
            Console.WriteLine(" Hello!");
            Console.WriteLine(" This application is designed to calculate monthly loan payments.");

            //
            // get the user's name and echo it back
            //
            Console.WriteLine();
            Console.Write(" What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine(" It is nice to meet you " + userName + ".");

            //
            // other methods to embed variables in a string
            //
            //Console.WriteLine("It is nice to meet you {0}.", userName);
            //Console.WriteLine($"It is nice to meet you {userName}.");

            //
            // determine if the user is looking for a loan
            //
            Console.WriteLine();
            Console.Write($" Are you interested in getting a loan {userName}?");
            userResponse = Console.ReadLine();

            //
            // get more information if the user is looking for a loan
            //
            if (userResponse == "yes")
            {
                //
                //      *******************************
                //      *   User Information Screen   *
                //      *******************************
                //
                // set cursor visible and clear screen
                //
                Console.CursorVisible = true;
                Console.Clear();

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
                // get user bank info
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
                Console.WriteLine("\t\"Home\"  \"Vehicle\"  \"College\"  \"Personal\"");
                Console.Write(" Enter loan type:");
                typeOfLoan = Console.ReadLine();

                //
                // get the principle of the loan
                //
                Console.WriteLine();
                Console.Write(" Please tell me the amount of the loan.");
                Console.Write(" Enter loan amount:");
                userResponse = Console.ReadLine();
                loanPrinciple = Convert.ToDouble(userResponse);

                //
                // get the length of the loan
                //
                Console.WriteLine();
                Console.WriteLine(" Please tell me the length of the loan in years");
                Console.Write(" Enter length of loan:");
                userResponse = Console.ReadLine();
                loanTermMonths = Convert.ToInt32(userResponse) * 12;

                //
                // assign the interest rate based on the loan type
                //
                Console.WriteLine();
                if (typeOfLoan.ToUpper() == "HOME")
                {
                    loanInterestRate = 0.0375 / 12;
                }
                else if (typeOfLoan.ToUpper() == "VEHICLE")
                {
                    loanInterestRate = 0.0425 / 12;
                }
                else if (typeOfLoan.ToUpper() == "COLLEGE")
                {
                    loanInterestRate = 0.0375 / 12;
                }
                else if (typeOfLoan.ToUpper() == "PERSONAL")
                {
                    loanInterestRate = 0.075 / 12;
                }
                else // user's response was not a valid loan type
                {
                    loanInterestRate = 0.0;
                }

                if (loanInterestRate != 0.0)
                {
                    //
                    // calculate the monthly payments
                    //
                    double factor = (loanInterestRate * (Math.Pow(loanInterestRate + 1, loanTermMonths))) / (Math.Pow(loanInterestRate + 1, loanTermMonths) - 1);
                    monthlyPayment = loanPrinciple * factor;
                }
                else
                {
                    Console.WriteLine(" I am afraid I don't recognize that type of loan.");
                    Console.WriteLine(" I am sorry that I will not be able to help you.");
                    Console.WriteLine(" Have a nice day.");
                }

                //
                //      *******************************
                //      *   Loan Information Screen   *
                //      *******************************
                //
                // clear screen
                //
                Console.Clear();

                //
                // display loan information
                //
                Console.WriteLine();


            }
            else
            {
                //
                //      **********************************
                //      *   User Not Interested Screen   *
                //      **********************************
                //
                // set cursor visible and clear screen
                //

                Console.CursorVisible = true;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($" I am sorry you are not looking for a loan {userName}, but this application ");
                Console.WriteLine(" is for people interested in the monthly payments for a specific loan.");
                Console.WriteLine(" Have a nice day.");

                //
                // display a prompt to exit the application
                //
                Console.WriteLine();
                Console.WriteLine(" Press any key to continue.");
                Console.ReadKey();
            }

            //
            //      **********************
            //      *   Closing Screen   *
            //      **********************
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //
            Console.CursorVisible = false;
            Console.BackgroundColor = openingClosingScreenBackground;
            Console.ForegroundColor = openingClosingScreenForeground;
            Console.Clear();

            //
            // display a closing screen
            // 
            Console.WriteLine();
            Console.WriteLine("\t\tThank You for Your Interest in Our Application");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to exit.");
            Console.ReadKey();
        }
    }
}
