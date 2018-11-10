using System;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe eine Zahl ein:");
            int number = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Von welchem System möchtest du die Zahl konvertieren?");
            int fromSystem = int.Parse(Console.ReadLine());

            Console.WriteLine("Zu welchem System möchtest du die Zahl konvertieren?");
            int toSystem = int.Parse(Console.ReadLine());

            Console.WriteLine("Die Lösung ist:");
            Console.WriteLine(ConvertNumberFromSystemToSystem(number, fromSystem, toSystem));
        }

        static int ConvertNumberFromSystemToSystem(int number, int fromSystem, int toSystem)
        {
            int result = 0;
            result = OtherToDecimal(number, fromSystem);
            result = DecimalToOther(result, toSystem);
            return result;
        }

        static int DecimalToOther(int dec, int system)
        {
            int result = 0;
            int factor = 1;
            while (dec != 0)
            {
                int digit = dec % system;
                dec /= system;
                result += factor * digit;
                factor *= 10;
            }
            return result;
        }

        static int OtherToDecimal(int other, int system)
        {
            int result = 0;
            int factor = 1;
            while (other != 0)
            {
                int digit = other % 10;
                other /= 10;
                result += factor * digit;
                factor *= system;
            }
            return result;
        }




    }
}
