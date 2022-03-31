using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface CalculatorUI
    {
        public void DisplayOperations();
        public double? RequestArgument();
        public void ShowError();
        public void ShowResult(double result);
        public int SelectOperationIndex();
    }
}
