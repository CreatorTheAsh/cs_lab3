using System;

namespace cs_lab3.Figures
{
    public class Tringle : Figure
    {
        public int SideC { get; set; }
        public Tringle()
        {
            Console.WriteLine("Создан триугольник.");
        }
        public Tringle(int SideA, int SideB,
            int CoordinateX, int coordinateY)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.CoordinateX = CoordinateX;
            this.CoordinateY = CoordinateY;
            this.FigureColor = TempColor;
        }
        public Tringle(int SideA, int SideB,
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
