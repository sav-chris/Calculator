using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class BinaryOperation : Operation
    {
        public Func<double, double, double> BinaryFunction { get; set; }

        public BinaryOperation(string name, Func<double, double, double> binaryFunction)
        {
            this.Name = name;
            this.BinaryFunction = binaryFunction;
        }

    }

}
