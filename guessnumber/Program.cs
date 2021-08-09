using System;

namespace guessnumber
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetAppInfo();

            while (true)
            {

                //Create a new Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //Get user inputNumber
                    string inputNumber = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(inputNumber, out guess))
                    {
                        //Tell user it's not a number
                        Console.WriteLine("Please enter a number!");

                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(inputNumber);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        Console.WriteLine("Wrong number, try again ! :)");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Congratulation, this is the number: {0}", correctNumber);
                    }
                }
                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
            }

        }

        static void GetAppInfo()
        {
            // set app var
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Rad Mircea-George";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Write out app info
            Console.ResetColor();

        }
        
        static void GreetAppInfo()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0} , let's play a game!", userName);
        }
    }
}
