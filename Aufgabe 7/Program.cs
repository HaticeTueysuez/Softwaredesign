using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe_7
{
    class Program
    {
        public static List<Quizelement> allQuestions = new List<Quizelement>();
        static int currentQuizelement = 0;

        static void Main(string[] args)
        {
            defaultQuestions();
            Quiz();
        }

        public static void Quiz() // Henri: Damit die Funktion nach beantworten oder einpflegen einer Frage wieder aufgerufen wird, sollte entweder eine Schleife oder ein rekursiver Aufruf implementiert werden
        {
            Console.WriteLine("Möchtest du ein Spiel spielen Ja/Nein"); // Henri: Besser wäre evt. eine Übersicht mit Möglichkeiten aus denen der User wählen kann (Momentan gibt es keine Möglichkeit das Programm direkt zu beenden)
            string input = Console.ReadLine();

            if (input.Equals("Ja"))
            {
                askAllQuestions(allQuestions[currentQuizelement]);

            }
            
            else if (input.Equals("Nein"))
            {
                Console.WriteLine("Dann musst du jetzt Fragen für mich beantworten"); 
                userQuestion();
            }

            else
            {
                Console.WriteLine("Eingabe nicht erkannt");
            }

            Console.WriteLine("Wenn du wieder zurück zum Anfang willst, tippe 'weiter' ein, zum Beenden beliebige Taste eingeben"); //Henri: Zum Beenden des Programms wäre z.B. Environment.Exit(0) besser geeignet
            if (Console.ReadLine().Equals("weiter"))
            {
                Quiz();
            }
        }

        public static void defaultQuestions() // Henri: createDefaultQuestions wäre evt passender
        {

            allQuestions.Add(new QuizSingle("Wer war der erste Bundeskanzler", new Answer[] {
                new Answer("1) Angela Merkel",false),
                new Answer("2) Barack Obama",false),
                new Answer("3) Helmut Kohl",false),
                new Answer("4) Konrad Adenauer",true)
            }));

            allQuestions.Add(new QuizMultiple("Welche Städte liegen im Schwarzwald?", new Answer[] {
                new Answer("1) Furtwangen",true),
                new Answer("2) Ravensburg",false),
                new Answer("3) Blumberg",true),
                new Answer("4) Konstanz",false)
            }));
            
            allQuestions.Add(new QuizBinary("Ist Istanbul die Hauptstadt der Türkei?", false));

            allQuestions.Add(new QuizGuess("Wann gewann Deutschland zuletzt die Fußball-Weltmeisterschaft?", 2014));

            allQuestions.Add(new QuizFree("Alle meine ... schwimmen auf dem See", "Entchen"));

        }

        public static void askAllQuestions(Quizelement quizelements)
        {
            int counter = 0; // Henri: Falls sich "counter" auf die Anzahl aller richtig beantworteten Fragen bezieht, wäre amountOfCorrectAnsweredQuestions o.a. besser
            int frage = 1; // Henri: Falls sich "frage" hier auf die Gesamtanzahl aller Fragen bezieht, wäre amountOfQuestions o.ä. besser. (Im Allgemeinen immer englische Bezeichner verwenden)

            quizelements.Show();
            Console.Write("\nBitte eine Antwort wählen: ");
            
            int AnswerChoice = int.Parse(Console.ReadLine()) - 1; // Henri: Variablennamen sollten mit einem Kleinbuchstaben anfangen
            
            if (quizelements.answers[AnswerChoice].IsAnswerCorrect())
            {
                counter++;
                Console.Write("\nRichtig!\n");
            }
            
            else
            {
                Console.Write("\nFalsch\n");
            } 
            currentQuizelement++;
            frage++;
            Console.WriteLine();
            Console.WriteLine(counter + "von" + (frage - 1) + " Fragen richtig beantwortet."); // Henri: Wieso wird "frage" oben der Wert eins zugewiesen wenn hier wieder eins abgezogen werden muss ? 
        }
            
        public static void userQuestion() // Henri: addNewQuizelement wäre als Name evt. besser geeignet
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
            allQuestions.Add(new QuizSingle(addUserQuestion, userAnswer));
        }

    }
}
