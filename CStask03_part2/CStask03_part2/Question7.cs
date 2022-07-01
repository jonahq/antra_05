using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;
        internal Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        internal Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }
        public void Set(int r, int g, int b, int a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;

        }

        public int[] Get()
        {
            return new int[] { red, green, blue, alpha };
        }

        public double grayScale()
        {
            return (red + green + blue) / 3.0;
        }
    }

    public class Ball
    {
        private string color;
        private int size;
        private int throwcount;
        public Ball(string c, int s)
        {
            color = c;
            size = s;
        }
        public void Pop() { size = 0; }
        public void Throw(){ throwcount += 1; }

        public int getThrow() { return throwcount; }
    }
}
