using System;
using cs_lab3.Figures;
namespace cs_lab3.Commands
{
    public class EllipseCommand : ICommand
    {
        Random rnd = new Random();
        private Ellipse _ellipse;
        public EllipseCommand(Ellipse ellipse)
        {
            _ellipse = ellipse;
        }
        public void Move()
        {
            Console.WriteLine("Ellipse Moved");
            _ellipse.Move(rnd.Next(0,10), rnd.Next(0, 10));
        }
        public void ReSize()
        {
            Console.WriteLine("Ellipse Resized");
            _ellipse.ReSize(rnd.Next(0, 10), rnd.Next(0, 10));
        }
        public void Paint()
        {
            
            Color Chosed = new Color();
            switch (rnd.Next(0, 6))
            { 
                case 1: Chosed.setWhite(); Console.WriteLine("Ellipse painted in white"); break;
                case 2: Chosed.setRed(); Console.WriteLine("Ellipse painted in Red"); break;
                case 3: Chosed.setGreen(); Console.WriteLine("Ellipse painted in Green"); break;
                case 4: Chosed.setBlue(); Console.WriteLine("Ellipse painted in Blue"); break;
                case 5: Chosed.setBlack(); Console.WriteLine("Ellipse painted in Black"); break;
                default: Chosed.setWhite(); Console.WriteLine("Ellipse painted in default - White"); break;
            }
            _ellipse.Paint(Chosed);
        }
        public void Undo()
        {
            _ellipse.Undo();
        }
        public override string ToString()
        {
            return "Изменить элипс";
        }
    }
}
