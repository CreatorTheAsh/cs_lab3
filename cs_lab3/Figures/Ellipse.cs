using System;

namespace cs_lab3.Figures
{
    public class Ellipse : Figure
    {
        public Ellipse()
        {
            Console.WriteLine("Создан элипс.");
        }
        public Ellipse(int SideA, int SideB,
            int CoordinateX, int coordinateY)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.CoordinateX = CoordinateX;
            this.CoordinateY = CoordinateY;
            this.FigureColor = TempColor;
        }
        public Ellipse(int SideA, int SideB,
            int CoordinateX, int CoordinateY,
            Color FigureColor)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.CoordinateX = CoordinateX;
            this.CoordinateY = CoordinateY;
            this.FigureColor = FigureColor;
        }
    }
}
