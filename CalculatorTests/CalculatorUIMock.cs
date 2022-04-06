using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace CalculatorTests
{
    class CalculatorUIMock : Calculator.CalculatorUI
    {
        private List<double> arguments = new List<double>();

        private Calculator.Controller Controller { get; }

        public void DisplayOperations()
        {
            
        }

        public double? RequestArgument()
        {
            if (arguments.Count > 0)
            {
                double first = arguments[0];
                arguments.Remove(0);
                return first;
            }
            return 5;
        }

        public int SelectOperationIndex()
        {
            return 1;
        }

        public void ShowError()
        {

        }

        public void ShowResult(double result)
        {
            
        }

        public void Run()
        {
            this.Controller.Run(this);
        }

        public CalculatorUIMock(Controller controller, List<double> arguments)
        {
            this.Controller = controller;
            this.arguments = arguments;
        }
    }
}
