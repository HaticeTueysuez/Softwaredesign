using System;

namespace Aufgabe_6
{
    public class Answer
    {
        public String text;
        public Boolean correct;

        public Answer(String text, Boolean correct) {
            this.text = text;
            this.correct = correct;
        }
        public Boolean IsAnswerCorrect() {
            return correct;
        }

    }
}