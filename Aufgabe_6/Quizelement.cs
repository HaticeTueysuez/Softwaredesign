using System;

namespace Aufgabe_6
{
    public class Quizelement
    {
        public string question;
        public Answer[] answers;


        public Quizelement(String question, Answer[] answers)
        {
            this.question = question;
            this.answers = answers;
        }

        public void Show()
        {
            Console.Write("\n" + question + "\n");

            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine(answers[i].text);

            }
        } 

    }
}