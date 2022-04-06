using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Calculator
{
    public class Controller
    {
        public List<Operation> Operations { get; }

        public int OperationCount
        {
            get
            {
                return Operations.Count;
            }
        }

        private Operation SelectOperation(CalculatorUI userInterface)
        {
            int index = userInterface.SelectOperationIndex();
            return (0 < index && index <= Operations.Count) ? Operations.ElementAt(index-1) : null;
        }

        public void AddOperation(Operation operation)
        {
            Operations.Add(operation);
        }

        public void Run(CalculatorUI userInterface)
        {
            Operation operation;
            do
            {
                userInterface.DisplayOperations();
                operation = SelectOperation(userInterface);
                if (!(operation is null))
                {
                    double? x = userInterface.RequestArgument();
                    double? y = userInterface.RequestArgument();
                    if (x is null || y is null)
                    {
                        userInterface.ShowError();
                    }
                    else
                    {
                        userInterface.ShowResult(operation.BinaryFunction(x.Value, y.Value));
                    }
                }
            }
            while (!(operation is null));

        }


        public Controller()
        {
            Operations = new List<Operation>();
            this.AddOperation(new Operation("Add", (x, y) => x + y));
            this.AddOperation(new Operation("Subtract", (x, y) => x - y));
            this.AddOperation(new Operation("Multiply", (x, y) => x * y));
            this.AddOperation(new Operation("Divide", (x, y) => x / y));
            this.AddOperation(new Operation("Exponent", (x, y) => Math.Pow(x, y)));
        }
    }
}
