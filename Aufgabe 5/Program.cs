using System;

namespace Aufgabe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte einen Satz eingeben");
            string text = Console.ReadLine();
            string letters = reverseLetters(text);
            string words = reverseWords(text);
            string sentence = reverseSentence(text);
            Console.WriteLine(letters);
            Console.WriteLine(words);
            Console.WriteLine(sentence);

        }

        public static string reverseLetters(string text)
        {
            char[] letters = text.ToCharArray();
            Array.Reverse(letters);
            text = String.Join("", letters);
            return text;
        }

        public static string reverseWords(string text)
        {
            string[] words = text.Split(' ');
            Array.Reverse(words);
            text = String.Join(" ", words);
            return text;
        }
        public static string reverseSentence(string text)
        {
            string[] wordText = text.Split(' ');
            string turnWord = "";
            string[] finalText = new string[wordText.Length];

            for (int i = 0; i <= wordText.Length - 1; i++)
            {
                turnWord += wordText[i];

                string wordIsTurned = "";
                for (int k = turnWord.Length - 1; k >= 0; k--)
                {
                    wordIsTurned += turnWord[k];
                }
                turnWord = "";
                finalText[i] = wordIsTurned;

            }
            text = String.Join(" ", finalText);
            return text;

        }

    }
}
