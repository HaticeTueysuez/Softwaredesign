using System;

namespace Aufgabe_9
{

    class QuizSingle
    {
        public String question;
        public Answer[] answers;

        public QuizSingle(String question, Answer[] answers)
        {
            this.question = question;
            this.answers = answers;
        }

        public void ShowQuestion()
        {
            Console.Write($"\n{question}\n\n");

            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {answers[i].text}");
            }
        }

    }
}