using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class ConsoleUI : CalculatorUI
    {
        private Controller Controller { get ;}

        public void DisplayOperations()
        {
            Console.WriteLine("Choose an operation: ");
            int itemNo = 1;
            foreach (Operation operation in this.Controller.Operations)
            {
                string itemText = (itemNo++).ToString();
                Console.WriteLine(itemText + ". " + operation.Name);
            }

            Console.WriteLine((itemNo++).ToString() + ". Exit");
        }

        public double? RequestArgument()
        {
            Console.WriteLine("Provide Argument");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double arg))
            {
                return arg;
            }
            return null;
        }

        public void ShowError()
        {
            Console.WriteLine("Invalid input");
            Console.WriteLine(" ");
        }
        public void ShowResult(double result)
        {
            Console.WriteLine("The result is:");
            Console.WriteLine(result.ToString());
            Console.WriteLine(" ");
        }


        public int SelectOperationIndex()
        {
            string selection = Console.ReadLine();
            if( !Int32.TryParse(selection, out int selectionIndex))
            {
                selectionIndex = this.Controller.OperationCount + 1;
            }
            return selectionIndex;
        }

        public void Run()
        {
            this.Controller.Run(this);
        }

        public ConsoleUI(Controller controller)
        {
            this.Controller = controller;
        }
    }
}
