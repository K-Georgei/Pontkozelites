using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozelites
{
    public class DataService
    {
        public float A0;
        public float A1;


        public void SetValues(BindingList<Pont2D> pontok, out float minX, out float minY, out float maxX, out float maxY, out float a0, out float a1)
        {
            minX = pontok.Min(p => p.X);
            minY = pontok.Min(p => p.Y);
            maxX = pontok.Max(p => p.X);
            maxY = pontok.Max(p => p.Y);

            float xsum = pontok.Sum(p => p.X);
            float ysum = pontok.Sum(p => p.Y);
            float x2sum = pontok.Sum(p => p.X2);
            float xysum = pontok.Sum(p => p.XY);
            int n = pontok.Count;

            a0 = (x2sum * ysum - xsum * xysum) / (n * x2sum - (xsum * xsum));
            a1 = (n * xysum - xsum * ysum) / (n * x2sum - (xsum * xsum));
            A0 = a0;
            A1 = a1;
        }

        public float GetA0()
        {
            return A0;
        }
        public float GetA1()
        {
            return A1;
        }

        public List<float> CalculateError(BindingList<Pont2D> pontok, float a0, float a1)
        {
            List<float> errors = new List<float>();

            foreach (Pont2D p in pontok)
            {
                float d = (float)Math.Pow(p.Y - (a1 * p.X + a0), 2);
                errors.Add(d);
            }

            return errors;
        }

        public List<Pont2D> Normalize(List<Pont2D> pontok, float minX, float maxX, float minY, float maxY, int width = 1, int height = 1)
        {
            List<Pont2D> tmp = new List<Pont2D>();

            if (pontok.Count > 1)
            {
                float padding = 0.0001f;
                if (maxX - minX == 0)
                {
                    maxX += padding;
                    minX -= padding;
                }
                if (maxY - minY == 0)
                {
                    maxY += padding;
                    minY -= padding;
                }

                foreach (var p in pontok)
                {
                    float normX = (p.X - minX) / (maxX - minX) * width;
                    float normY = (p.Y - minY) / (maxY - minY) * height;
                    tmp.Add(new Pont2D(normX, normY));
                }

                return tmp;
            }
            else
            {
                return null;
            }
        }
    }
}
