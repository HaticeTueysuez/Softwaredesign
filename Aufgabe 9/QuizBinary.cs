using System;

namespace Aufgabe_9
{
    public class QuizBinary
    {
        public String question;
        public Boolean truth;

        public QuizBinary(String question, Boolean truth)
        {
            this.question = question;
            this.truth = truth;
        }

        public void ShowQuestion()
        {
            Console.Write($"\n{question}\n\n");
        }

    }
}
