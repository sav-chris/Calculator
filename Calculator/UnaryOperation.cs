using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UnaryOperation : Operation
    {
        public Func<double, double> UnaryFunction { get; set; }

        public UnaryOperation(string name, Func<double, double> unaryFunction)
        {
            this.Name = name;
            this.UnaryFunction = unaryFunction;
        }
    }
}
