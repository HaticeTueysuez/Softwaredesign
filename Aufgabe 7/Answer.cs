using System;

namespace Aufgabe_7
{
    class Answer
    {
        public string text;
        public bool correct;

        public Answer(string text, bool correct)
        {
            this.text = text;
            this.correct = correct;
        }

        public Boolean IsAnswerCorrect() {
            return correct;
        }

        
    }
}