using System;

namespace Aufgabe_6
{
    public class Quizelement
    {
        public string question;
        //public string[] answers;
        public Answer[] answers;
        //public int correct; 
    
    
        
        public bool IsAnswerCorrect(int choice)
        {
           Boolean test = this.answers[choice-1].correct;

           return test;
        }

        void Show()
        {
            

        }


    }
}