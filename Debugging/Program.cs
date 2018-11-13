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
            Person person1 = new Person { FirstName = "Hannah", LastName = "Wald", Age=new DateTime(1992,04,11) };
            Person person2 = new Person { FirstName = "Lisa", LastName = "Baum", Age=new DateTime(1995,02,12) };


    


            Console.WriteLine(person1);
        }
    }
}
