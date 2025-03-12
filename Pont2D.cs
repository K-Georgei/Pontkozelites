using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ScottPlot.Rendering.RenderActions;

namespace Kozelites
{
    public class Pont2D
    {
        public string Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float X2 { get; set; }
        public float XY { get; set; }

        public static int counter = 0; // Statikus számláló az összes példányhoz

        public Pont2D(float x = 0, float y = 0)
        {
            Name = $"p{++counter}";    
            X = x;
            Y = y;
            X2 = (float)Math.Pow(x, 2);
            XY = x * y;
           
        }

        

    }
}
