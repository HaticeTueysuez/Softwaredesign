using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Aufgabe_9
{
    class Program
    {
        static int score = 0;

        static List<QuizSingle> singleList = new List<QuizSingle>();
        static int currentQuizSingle = 0;

        static List<QuizMultiple> multipleList = new List<QuizMultiple>();
        static int currentQuizMultiple = 0;

        static List<QuizBinary> binaryList = new List<QuizBinary>();
        static int currentQuizBinary = 0;

        static List<QuizGuess> guessList = new List<QuizGuess>();
        static int currentQuizGuess = 0;

        static List<QuizFree> freeList = new List<QuizFree>();
        static int currentQuizFree = 0;


        static void Main(string[] args)
        {
            CreateNewQuiz();
            Program p = new Program();
            p.QuizMenu(score);
        }


        public static void CreateNewQuiz()
        {
            singleList.Add(new QuizSingle("Wer war der erste Bundeskanzler", new Answer[] {
                new Answer("Angela Merkel",false),
                new Answer("Barack Obama",false),
                new Answer("Helmut Kohl",false),
                new Answer("Konrad Adenauer",true)
            }));

            multipleList.Add(new QuizMultiple("Welche Städte liegen im Schwarzwald?", new Answer[] {
                new Answer("Furtwangen",true),
                new Answer("Ravensburg",false),
                new Answer("Blumberg",true),
                new Answer("Konstanz",false)
            }));

            binaryList.Add(new QuizBinary("Ist Ankara die Hauptstadt der Türkei?", true));

            guessList.Add(new QuizGuess("Schätze, wie viele Studenten die HFU hat.", 6687));

            freeList.Add(new QuizFree("Alle meine ... schwimmen auf dem See", "Entchen"));

        }

        public void QuizMenu(int score)
        {
            Console.WriteLine("Deine Punktzahl: " + score);
            Console.WriteLine("Tippe 1: Quiz beantworten");
            Console.WriteLine("Tippe 2: Fragen hinzufügen");
            Console.WriteLine("Tippe 3: Programm beenden");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                ChooseQuestionType(score);
            }

            if (choice == 2)
            {
                Program p = new Program();
                p.AddNewQuestion();
            }

            else
            {
                Console.WriteLine("\nAuf Wiedersehen.");
            }
        }

        public void ChooseQuestionType(int score)
        {
            Console.WriteLine("Welchen Fragetyp willst du beantworten?");
            string type = Console.ReadLine();

            if (type == "Single")
            {
                AnswerQuizSingle(singleList[currentQuizSingle]);
            }
            if (type == "Multiple")
            {
                AnswerQuizMultiple(multipleList[currentQuizMultiple]);
            }
            if (type == "Binary")
            {
                AnswerQuizBinary(binaryList[currentQuizBinary]);
            }
            if (type == "Guess")
            {
                AnswerQuizGuess(guessList[currentQuizGuess]);
            }
            if (type == "Free")
            {
                AnswerQuizFree(freeList[currentQuizFree]);
            }
        }

        public static void AnswerQuizSingle(QuizSingle singleElement)
        {

            singleElement.ShowQuestion();
            Console.WriteLine("Bitte wähle die richtige Antwort:");
            if (singleElement.answers[Int32.Parse(Console.ReadLine()) - 1].IsAnswerCorrect())
            {
                score++;
                Console.Write("\nKorrekt!");
            }
            else
            {
                Console.Write("\nFalsch!");
            }
            Program p = new Program();
            p.QuizMenu(score);
        }

        public static void AnswerQuizMultiple(QuizMultiple multipleChoiceElement)
        {
            multipleChoiceElement.ShowQuestion();
            Console.WriteLine("\nDeine Antorten (durch ein Komma getrennt) ");
            string selectedAnswers = Console.ReadLine();
            string[] answer = selectedAnswers.Split(',');

            if (answer[0] == "1" && answer[1] == "3")
            {
                Console.WriteLine("Korrekt");
                score++;
            }

            else
            {
                Console.WriteLine("Falsch");
            }
            Program p = new Program();
            p.QuizMenu(score);
        }

        public static void AnswerQuizBinary(QuizBinary binaryElement)
        {
            Console.Clear();
            binaryElement.ShowQuestion();
            Console.WriteLine("Beantworte die Frage mit J bzw N");
            string UserInput = Console.ReadLine();

            if (UserInput == "J")
            {
                Console.WriteLine("Korrekt");
                score++;
            }

            else
            {
                Console.WriteLine("Falsch");
            }

            Program p = new Program();
            p.QuizMenu(score);
        }

        public static void AnswerQuizGuess(QuizGuess guessElement)
        {
            Console.Clear();
            guessElement.ShowQuestion();
            Console.WriteLine("Gib deine Schätzung ein:");
            double number = double.Parse(Console.ReadLine());

            double toleranceMin = 6687 * 0.09;
            double toleranceMax = 6687 * 1.1;

            if (number >= toleranceMin && number <= toleranceMax)
            {
                Console.WriteLine("Korrekt");
                score++;
            }

            else
            {
                Console.WriteLine("Falsch");
            }

            Program p = new Program();
            p.QuizMenu(score);


        }

        public static void AnswerQuizFree(QuizFree freeElement)
        {
            Console.Clear();
            freeElement.ShowQuestion();
            Console.Write("\nGib das richtige Wort ein:  ");
            string rightWord = Console.ReadLine();

            if (rightWord == "Entchen")
            {
                Console.WriteLine("Korrekt");
                score++;
            }

            else
            {
                Console.WriteLine("Falsch");
            }

            Program p = new Program();
            p.QuizMenu(score);
        }

        public void AddNewQuestion()
        {
            Console.WriteLine("Wähle den Fragen-Typ aus:");
            string addQuestionType = Console.ReadLine();
            
            Console.WriteLine("Gib eine neue Frage ein:");
            string addUserQuestion = Console.ReadLine();

            Console.WriteLine("Wie viele Antwortmöglichkeiten soll deine Frage haben?");
            int addHowManyAnswers = int.Parse(Console.ReadLine());

            Console.WriteLine("Schreibe die richtige Antwort:");
            string yourAnswer = Console.ReadLine();

            int i = 1;

            while(i < addHowManyAnswers)
            {
                Console.WriteLine("Schreibe die nächste Antwortmöglichkeit");
                string userAnswer = Console.ReadLine();
                i++;
            }
            SaveQuestion(addQuestionType, addUserQuestion, addHowManyAnswers, yourAnswer);
            
        }

        static void SaveQuestion(string addQuestionType, string addUserQuestion, int addHowManyAnswers, string yourAnswer)
        {
            
            FileStream read = new FileStream("AddQuestion.xml", FileMode.Open);

            XmlSerializer type = new XmlSerializer(addQuestionType.GetType());
            type.Serialize(read,addQuestionType);

            XmlSerializer question = new XmlSerializer(addUserQuestion.GetType());
            question.Serialize(read,addUserQuestion);

            XmlSerializer howManyAnswers = new XmlSerializer(addHowManyAnswers.GetType());
            howManyAnswers.Serialize(read,addHowManyAnswers);

            XmlSerializer answer = new XmlSerializer(yourAnswer.GetType());
            answer.Serialize(read,yourAnswer);

            Program p = new Program();
            p.QuizMenu(score);

        }
        
    }
}
