using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStart.TDD
{
    public class CalculatorV2
    {
        public int GetMin(int a, int b)
        {
            return a > b ? b : a;
        }
    }
}
