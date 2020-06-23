using System;
using System.Collections.Generic;
using System.Text;
using cs_lab3.Commands;
using cs_lab3.Figures;

namespace CommandSample
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.OutputEncoding = Encoding.UTF8;
            var remote = new RemoteControl();
            string userInput;

            remote.SetCommandForButton(1, new EllipseCommand(new Ellipse()));
            remote.SetCommandForButton(2, new TringleCommand(new Tringle()));
            // remote.SetCommandForButton(3, macroCommand);

            do
            {
                Console.WriteLine("Выберите вариант ниже:");
                Console.WriteLine(remote);

                Console.Write("\nВаш выбор: ");
                var input = Console.ReadLine();
                int buttonId;
                int.TryParse(input, out buttonId);

                remote.PushButton(buttonId);
                remote.UndoButton(buttonId);

                Console.Write("\nВы хотите продолжить (y/n): ");
                userInput = Console.ReadLine();
            } while (userInput == "y");
        }
    }
}
