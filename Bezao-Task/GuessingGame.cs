using System;
using System.Diagnostics;

namespace GuessingGame
{

    public class PlayGuessingGame
    {

        public void RunGuessingGame()
        
        {  
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 10;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);


                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too Low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You Win!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N):");
                response = Console.ReadLine();
                response = response.ToUpper();


                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing the Guessing Game");
            Console.ReadKey();
            
        }   
        
    }
}
//To run any of the codes in Program.cs, comment the other one 








