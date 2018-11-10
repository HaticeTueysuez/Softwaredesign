using System;

public class Person
{
   public string FirstName;
   public string LastName;
   public DateTime Age;
  

   public override string ToString() { 
       return "Person: " + FirstName + " " + LastName + " " + Age;
   }
}

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { FirstName = "Hatice", LastName = "Tüysüz", Age=new DateTime(1996,11,11) };
            Person person2 = new Person { FirstName = "Bilge", LastName = "Tad", Age=new DateTime(1997,07,12) };
            Person person3 = new Person { FirstName = "Zehra", LastName = "Ünal", Age=new DateTime(1997,03,14) };
            Person person4 = new Person { FirstName = "Muha", LastName = "Tüysüz", Age=new DateTime(2001,03,26) };
            Person person5 = new Person { FirstName = "Sümeyra", LastName = "Kabakli", Age=new DateTime(2012,02,16) };

        for(int i=0; i>=;i++)

        for (DateTime=)
        Console.WriteLine();


            Console.WriteLine(person1);
        }
    }
}
