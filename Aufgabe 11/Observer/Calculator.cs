using System;

namespace Observer
{
    public delegate void ReportProgressMethod(int progress);
    class Calculator
    {
        public event ReportProgressMethod ProgressMethod;
        public Calculator()
        {
            ProgressMethod += ProgressReport;
        }

        public void CalculateSomething()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 20 || i == 40 || i == 60 || i == 80 || i == 100)
                {
                    ProgressMethod(i);
                }
            }
        }

        public void ProgressReport(int _progress)
        {
            Console.WriteLine(_progress + " %");
        }

    }
}