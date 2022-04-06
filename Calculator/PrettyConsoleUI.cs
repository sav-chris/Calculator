using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class PrettyConsoleUI : CalculatorUI
    {
        private Controller Controller { get; }

        private void SetColours()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void DisplayOperations()
        {
            SetColours();

            Console.WriteLine("Choose an operation: ");
            int itemNo = 1;
            foreach (BinaryOperation operation in this.Controller.Operations)
            {
                string itemText = (itemNo++).ToString();
                Console.WriteLine(itemText + ". " + operation.Name);
            }

            Console.WriteLine((itemNo++).ToString() + ". Exit");
        }

        public double? RequestArgument()
        {
            SetColours();

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
            SetColours();
            Console.WriteLine("Invalid input");
            Console.WriteLine(" ");
        }
        public void ShowResult(double result)
        {
            SetColours();
            Console.WriteLine("The result is:");
            Console.WriteLine(result.ToString());
            Console.WriteLine(" ");
        }


        public int SelectOperationIndex()
        {
            string selection = Console.ReadLine();
            if (!Int32.TryParse(selection, out int selectionIndex))
            {
                selectionIndex = this.Controller.OperationCount + 1;
            }
            return selectionIndex;
        }

        public void Run()
        {
            this.Controller.Run(this);
        }

        public PrettyConsoleUI(Controller controller)
        {
            this.Controller = controller;
        }
    }
}
