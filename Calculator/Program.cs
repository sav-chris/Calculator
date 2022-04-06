using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI userinterface = new ConsoleUI(new Controller());
            userinterface.Run();


        }
    }
}
