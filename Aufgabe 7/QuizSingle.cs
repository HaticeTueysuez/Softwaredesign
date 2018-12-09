using System;

namespace Aufgabe_7
{

    class QuizSingle:Quizelement
    {
        public int correct;
        public QuizSingle(String question, Answer[] answers)
        {
            this.question = question;
            this.answers = answers;
        }
        
        
    }
}