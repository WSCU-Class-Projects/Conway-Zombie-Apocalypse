using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Cell
    {
        public int red;
        public int green;
        public int blue;

        public Cell(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;

        }

        public Color colored()
        {
            return Color.FromArgb(red, green, blue);
        }


    }
}
    

