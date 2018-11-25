using System;

namespace Aufgabe_6
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            Quizelement quiz1 = new Quizelement();
            Console.WriteLine(quiz1);
            quiz1.question = "Wer war der erste Bundeskanzler der BRD?";

            Answer answer1 = new Answer();    //neues Objekt erstellt 
            answer1.text="Barack Obama";
            answer1.correct=false;
            Answer answer2 = new Answer();
            answer2.text="Konrad Adenauer";
            answer2.correct=true;

            quiz1.answers = new Answer[] {answer1, answer2}; 

            
            Boolean test2 = quiz1.IsAnswerCorrect(1);
            Console.WriteLine(test2);

        }






    }
}
