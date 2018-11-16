using System;
using System.Collections.Generic;
using System.Collections;

namespace Aufgabe_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte einen Satz eingeben");
            Console.Write("> ");
            var _userInput = Console.ReadLine();

            string letters = reverseLetters(_userInput);
            string words = reverseWords(_userInput);
            string sentence = reverseSentence(_userInput);

            Console.WriteLine(letters);
            Console.WriteLine(words);
            Console.WriteLine(sentence);
        }


        public static string reverseLetters(string _userInput)
        {
            List<char> listOfLetters = new List<char>();

            for (int i = _userInput.Length - 1; i > -1; i--)
            {
                listOfLetters.Add(_userInput[i]);
            }

            return string.Join("", listOfLetters);
        }


        public static string reverseWords(string _userInput)
        {
            List<string> listOfWords = new List<string>();
            String[] splittedWords = _userInput.Split(' ');

            for (int i = 0; i < splittedWords.Length; i++)
            {
                listOfWords.Add(splittedWords[i]);

            }

            listOfWords.Reverse();

            return string.Join(" ", listOfWords.ToArray());
        }

        public static string reverseSentence(string _userInput)
        {
            string reversedWord = reverseWords(_userInput);
            string reversedSentence = reverseLetters(reversedWord);

            return reversedSentence;
        }

    }
}
