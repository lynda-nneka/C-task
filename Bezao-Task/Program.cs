using System;
using GuessingGame;
using LeapYear;
using PigLatinTranslator;

namespace Bezao
{
    public class Program
    {
       
        
            static void Main(string[] args) {
                PlayGuessingGame guessingGame = new PlayGuessingGame();
                LeapYearGenerator leapYear = new LeapYearGenerator();
                TranslateToPigLatin piglatintranslator = new TranslateToPigLatin();

               //To run any of the codes, comment the other one
               
                //guessingGame.RunGuessingGame();
              //leapYear.GetLeapYear();
                piglatintranslator.PlayPigLatinTranslator();
            }


        }
    }


