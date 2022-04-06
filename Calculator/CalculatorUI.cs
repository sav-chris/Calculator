using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface CalculatorUI
    {
        public void DisplayOperations();
        public double? RequestArgument();
        public void ShowError();
        public void ShowResult(double result);
        public int SelectOperationIndex();
        public void Run();
    }
}
