using System;

namespace PigLatinTranslator
{
   public class TranslateToPigLatin
    {
        public void PlayPigLatinTranslator()
        {
            Console.WriteLine("Pig Latin Translator");
            Console.WriteLine();

            Console.Write("Enter Your Selected Word");
            string Word = Console.ReadLine();

            //Step 1
            int VowelPosition = -1;
            foreach(char letter in Word)
            {
                VowelPosition = VowelPosition + 1;
                if(letter =='a' || letter =='e' || letter =='i' || letter == 'o' || letter == 'u')
                {
                    break;
                }
            }
            //Step 2
            string PigLatinWord = "";
            string BeforeLetters = "";
            string AfterLetters = "";
            switch (VowelPosition)
            {
                case 0:
                    PigLatinWord = Word + "way";
                    break;
                case 1:
                    BeforeLetters = Word.Substring(0, 1);
                    AfterLetters = Word.Substring(1);
                    PigLatinWord = AfterLetters + BeforeLetters + "ay";
                    break;
                case 2:
                    BeforeLetters = Word.Substring(0, 2);
                    AfterLetters = Word.Substring(2);
                    PigLatinWord = AfterLetters + BeforeLetters + "ay";
                    break;
                    default:
                    PigLatinWord = "Not Translateable";
                    break;

       }

            Console.WriteLine("Your Translation: "+ PigLatinWord);
            Console.WriteLine();


            Console.WriteLine("--Press any key twice to exit or stay on this screen forever. It's your choice.--");
            Console.ReadKey();

     }


    }

}