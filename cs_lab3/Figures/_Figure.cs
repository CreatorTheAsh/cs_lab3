using System;
namespace cs_lab3.Figures
{              
   /* public struct State
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public Color FigureColor { get; set; }
    }*/
    public class Figure
    {
        //int SideA, SideB, CoordinateX, CoordinateY;
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public Color FigureColor { get; set; }
        public Color TempColor = new Color();

        public Figure (int SideA, int SideB,
            int CoordinateX, int coordinateY)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.CoordinateX = CoordinateX;
            this.CoordinateY = CoordinateY;
            this.FigureColor = TempColor;
        }
        public Figure(int SideA, int SideB,
            int CoordinateX, int CoordinateY,
            Color FigureColor)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.CoordinateX = CoordinateX;
            this.CoordinateY = CoordinateY;
            this.FigureColor = FigureColor;
        }
        public Figure()
        {
            SideA = 0;
            SideB = 0;
            CoordinateX = 0;
            CoordinateY = 0;
            FigureColor = TempColor;
        }
        public void Move(int CoordinateX, int CoordinateY) 
        {
            this.CoordinateX= CoordinateX ;
            this.CoordinateY = CoordinateY;
        }
        public void ReSize(int SideA, int SideB) 
        {
            this.SideA = SideA;
            this.SideB = SideB;
        }
        public void Paint(Color figureColor) 
        {
            this.FigureColor = FigureColor;
        }
        public void Undo()
        {
            SideA = 0;
            SideB = 0;
            CoordinateX = 0;
            CoordinateY = 0;
            FigureColor = TempColor;
        }
    }
}

