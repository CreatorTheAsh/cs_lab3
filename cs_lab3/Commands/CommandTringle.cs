using System;
using cs_lab3.Figures;
namespace cs_lab3.Commands
{
    public class TringleCommand : ICommand
    {
        Random rnd = new Random();
        private Tringle _tringle;
        public TringleCommand(Tringle tringle)
        {
            _tringle = tringle;
        }
        public void Move()
        {
            Console.WriteLine("Tringle Moved");
            _tringle.Move(rnd.Next(0, 10), rnd.Next(0, 10));
        }
        public void ReSize()
        {
            Console.WriteLine("Tringle Resized");
            _tringle.ReSize(rnd.Next(0, 10), rnd.Next(0, 10));
        }
        public void Paint()
        {

            Color Chosed = new Color();
            switch (rnd.Next(0, 6))
            {
                case 1: Chosed.setWhite(); Console.WriteLine("Tringle painted in white"); break;
                case 2: Chosed.setRed(); Console.WriteLine("Tringle painted in Red"); break;
                case 3: Chosed.setGreen(); Console.WriteLine("Tringle painted in Green"); break;
                case 4: Chosed.setBlue(); Console.WriteLine("Tringle painted in Blue"); break;
                case 5: Chosed.setBlack(); Console.WriteLine("Tringle painted in Black"); break;
                default: Chosed.setWhite(); Console.WriteLine("Tringle painted in default - White"); break;
            }
            _tringle.Paint(Chosed);
        }
        public void Undo()
        {
            _tringle.Undo();
        }
        public override string ToString()
        {
            return "Изменить треугольник";
        }
    }
}
