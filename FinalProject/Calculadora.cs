using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class Calculadora
    {
        private List<string> listHistory;

        public Calculadora()
        {
            listHistory = new List<string>();
        }

        public int Sum(int numberOne, int numberTwo)
        {
            int res = numberOne + numberTwo;
            listHistory.Insert(0, "Sum:" + res);
            return res;
        }

        public int Multiply(int numberOne, int numberTwo)
        {
            int res = numberOne * numberTwo;
            listHistory.Insert(0, "Multiply:" + res);
            return res;
        }

        public int Decrease(int numberOne, int numberTwo)
        {
            int res = numberOne - numberTwo;
            listHistory.Insert(0, "Decrease:" + res);
            return res;
        }

        public int Split(int numberOne, int numberTwo)
        {
            if (numberTwo == 0)
            {
                throw new ArgumentException("Cannot divide by zero");
            }
            int res = numberOne / numberTwo;
            listHistory.Insert(0, "Split:" + res);
            return res;
        }

        public List<string> History()
        {
            return listHistory;
        }
    }
}
