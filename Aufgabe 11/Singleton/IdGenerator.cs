using System;

namespace Singleton
{
    class IdGenerator
    {
        private int ID;
        private IdGenerator()
        {
            ID = 1;
        }

        private static IdGenerator _instance;
        public static IdGenerator Instance
        {
            get
            {
                if (_instance == null)
                _instance = new IdGenerator();
                return _instance;
            }
        }

        public int GenerateNewID()
        {
            return ID++;
        }

    }
}