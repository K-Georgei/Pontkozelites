using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kozelites
{
    public class Pont2D
    {
        private Graphics g;

        public string Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        private int i = 0;

        public Pont2D(float x = 0, float y = 0)
        {
            Name = $"p{namehelper()}";    
            X = x;
            Y = y;
        }

        private int namehelper()
        {
            i++;
            return i;
        }


    }
}
