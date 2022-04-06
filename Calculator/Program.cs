using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrettyConsoleUI userinterface = new PrettyConsoleUI(new Controller());
            userinterface.Run();


        }
    }
}
