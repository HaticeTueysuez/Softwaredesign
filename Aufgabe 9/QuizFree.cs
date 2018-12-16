using System;

namespace Aufgabe_9
{

    class QuizFree
    {
        public String question;
        public string rightWord;

        public QuizFree(String question, String rightWord)
        {
            this.question = question;
            this.rightWord = rightWord;
        }

        public void ShowQuestion()
        {
            Console.Write($"\n{question}\n\n");
        }

    }

}