using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace CalculatorTests
{
    class CalculatorUIMock : Calculator.CalculatorUI
    {
        private List<double?> arguments = new List<double?>();
        private double expetedResult;

        private Calculator.Controller Controller { get; }

        public void DisplayOperations()
        {
            
        }

        public double? RequestArgument()
        {
            if (arguments.Count > 0)
            {
                double? first = arguments[0];
                arguments.Remove(0);
                return first;
            }
            return null;
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
            if (expetedResult != result)
            {
                string msg = string.Format("Expected {0}, but calculated {1}", expetedResult, result);
                throw new ArithmeticException(msg);
            }
        }

        public void Run()
        {
            this.Controller.Run(this);
        }

        public CalculatorUIMock(Controller controller, List<double?> arguments, double expetedResult)
        {
            this.Controller = controller;
            this.arguments = arguments;
            this.expetedResult = expetedResult;
        }
    }
}
