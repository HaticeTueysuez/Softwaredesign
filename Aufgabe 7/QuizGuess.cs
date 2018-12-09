using System;

namespace Aufgabe_7
{


    class QuizGuess:Quizelement
    {
        public int range;
        public QuizGuess(String question, int range)
        {
            this.question = question;
            this.range = range;
        }

    }

}