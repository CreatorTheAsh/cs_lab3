using System;
namespace cs_lab3.Figures
{
    public class Color
    {
        public int Red;
        public int Green;
        public int Blue;
        public Color(int R, int G, int B)
        {
            Red = R;
            Green = G;
            Blue = B;
        }
        public Color()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }
        public void setWhite()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }
        public void setRed()
        {
            Red = 255;
            Green = 0;
            Blue = 0;
        }
        public void setGreen()
        {
            Red = 0;
            Green = 255;
            Blue = 0;
        }
        public void setBlue()
        {
            Red = 0;
            Green = 0;
            Blue = 255;
        }
        public void setBlack()
        {
            Red = 255;
            Green = 255;
            Blue = 255;
        }
    }
}