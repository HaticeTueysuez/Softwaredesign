using System;
using System.Collections.Generic;

namespace Aufgabe_6
{

    public class Program
    {
        static int score = 0;
        public static List<Quizelement> quizelementsList = new List<Quizelement>();

        static void Main(string[] args)
        {
            CreateNewQuiz();
            QuizMenu();
        }

        public static void QuizMenu()
        {
            while (true)
            {
                Console.WriteLine("Deine Highscore ist: " + score + "\n");
                Console.WriteLine("Bitte auswählen: :\n 1) Quiz beantworten\n 2) Neue Fragen stellen\n 3) Das Spiel beenden\n");


                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Random random = new Random();
                    int randomQuestion = random.Next(quizelementsList.Count);
                    AnswerQuestion(quizelementsList[randomQuestion]);
                    QuizMenu();
                }

                else if (choice == 2)
                {
                    AddNewQuestion();
                    QuizMenu();

                }

                else if (choice == 3)
                {
                    break;
                }

            }


        }

        public static void CreateNewQuiz()
        {
            quizelementsList.Add(new Quizelement("Wer war der erste Bundeskanzler?",
                new Answer[]{
                new Answer("1) Angela Merkel", false),
                new Answer("2) Brack Obama", false),
                new Answer("3) Helmut Kohl", false),
                new Answer("4) Konrad Adenauer", true)
            }));

            quizelementsList.Add(new Quizelement("Zu welcher Gruppe der Elementarteilchen gehört das Elektron?",
                new Answer[]{
                new Answer("1) Leptonen", true),
                new Answer("2) Quarks", false),
                new Answer("3) Gluonen", false),
                new Answer("4) Bosonen", false)
            }));

            quizelementsList.Add(new Quizelement("Welche der folgenden Planeten ist der Sonne am nächsten?",
                new Answer[]{
                new Answer("1) Erde", false),
                new Answer("2) Mars", false),
                new Answer("3) Venus", true),
                new Answer("4) Jupiter", false)
            }));
        }

        public static void AnswerQuestion(Quizelement quizelements)
        {
            quizelements.Show();
            Console.Write("\nBitte eine Antwort wählen ");
            int AnswerChoice = int.Parse(Console.ReadLine()) - 1;

            if (quizelements.answers[AnswerChoice].IsAnswerCorrect())
            {
                score += 1;
                Console.Write("\nRichtig\n");
            }
            else
            {
                Console.Write("\nFalsch\n");
            }

        }

        public static void AddNewQuestion()
        {
            Console.Write("Gebe eine neue Frage ein\n> ");
            String addUserQuestion = Console.ReadLine();
            Console.Write("Wieviele Antwortmöglichkeiten soll die Frage haben?\n> ");
            int addHowManyAnswers = Int32.Parse(Console.ReadLine());
            Answer[] userAnswer = new Answer[addHowManyAnswers];

            Console.Write("Gebe die Richtige Antwort ein: \n> ");
            userAnswer[0] = new Answer(Console.ReadLine(), true);
            for (int i = 1; i < addHowManyAnswers; i++)
            {
                Console.Write("Bitte weitere Antwortmöglichkeiten eingeben\n> ");
                userAnswer[i] = new Answer(Console.ReadLine(), false);
            }
            quizelementsList.Add(new Quizelement(addUserQuestion, userAnswer));
        }

    }
}
