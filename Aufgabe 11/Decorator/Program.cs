using System;
using System.Collections.Generic;

namespace Decorator
{
    interface Spielfigur
    {
        void Drohe();  
    }

    class Monster : Spielfigur
    {
        public void Drohe()
        {
            Console.Write("Grrrrr!");
        }
    } 


    class Held : Spielfigur
    {
        public void Drohe()
        {
            Console.Write("Weiche zurück!");
        }        
    }


    // Decorator
    class BasisDekorierer : Spielfigur
    {
        private Spielfigur _original;
        public BasisDekorierer(Spielfigur original)
        {
            this._original = original;
        }
        
        virtual public void Drohe()
        {
            _original.Drohe();
        }
    }

    class ErkaelteteFigur : BasisDekorierer
    {
        public ErkaelteteFigur(Spielfigur original) : base(original){}
        
        public override void Drohe()
        {
            base.Drohe();
            Console.Write(" Hust!");
        }
    }

    class HeisereFigur : BasisDekorierer
    {
        public HeisereFigur(Spielfigur original) : base(original){}
   
        public override void Drohe()
        {
            Console.Write("Räusper...");
            base.Drohe();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Spielfigur> figuren = new List<Spielfigur>();

            figuren.Add(new Monster());
            figuren.Add(new Held());
            figuren.Add(new ErkaelteteFigur(new Held()));
            figuren.Add(new ErkaelteteFigur(new ErkaelteteFigur(new Monster())));
            figuren.Add(new HeisereFigur(new Monster()));
            figuren.Add(new ErkaelteteFigur(new HeisereFigur(new Held())));

            foreach(var spielfigur in figuren)
            {
                spielfigur.Drohe();
                Console.WriteLine();
            }

        }
    }
}