using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id = IdGenerator.Instance.GenerateNewID();
            Console.WriteLine(Id);
            int Id2 = IdGenerator.Instance.GenerateNewID();
            Console.WriteLine(Id2);
        }
    }
}
