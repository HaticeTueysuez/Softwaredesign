using System;

namespace Aufgabe_7
{
    class QuizBinary : Quizelement
    {
        public Boolean truth;

        public QuizBinary(String question, Boolean truth)
        {
            this.question = question;
            this.truth = truth;
        }

        
    }
    
}