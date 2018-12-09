using System;

namespace Aufgabe_7
{
    class Quizelement
    {
        public String question;
        public Answer[] answers;

        public void Show()
        {
            Console.Write("\n" + question + "\n");

            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine(answers[i].text);

            }
        }

        public Boolean IsAnswerCorrect()
        {
            return false;
        }

    }

}