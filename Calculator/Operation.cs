using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Operation
    {
        public string Name { get; set; }

        public Func<double, double, double> BinaryFunction { get; set; }

        public Operation(string name, Func<double, double, double> binaryFunction)
        {
            this.Name = name;
            this.BinaryFunction = binaryFunction;
        }

    }

}
