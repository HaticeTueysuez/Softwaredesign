using System;

namespace Aufgabe_9
{
    class QuizGuess
    {
        public String question;
        public int range;
        public QuizGuess(String question, int range)
        {
            this.question = question;
            this.range = range;
        }

        public void ShowQuestion()
        {
            Console.Write($"\n{question}\n\n");
        }

    }

}