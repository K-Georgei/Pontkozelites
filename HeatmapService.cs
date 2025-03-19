using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozelites
{
    public class HeatmapService
    {
        private readonly DataService _dataService;
        private readonly PlotService _plotService;

        public HeatmapService(DataService dataService, PlotService plotService)
        {
            _dataService = dataService;
            _plotService = plotService;
        }

        public void GenerateHeatmap(FormsPlot formsPlot, PictureBox pictureBox, BindingList<Pont2D> pontok, float a0, float a1)
        {
            int gridWidth = formsPlot.Size.Width;
            int gridHeight = formsPlot.Size.Height;
            Bitmap bitmap = new Bitmap(gridWidth, gridHeight);

            _dataService.SetValues(pontok, out float minX, out float minY, out float maxX, out float maxY, out a0, out a1);
            List<Pont2D> normpont = _dataService.Normalize(pontok.ToList(), minX, maxX, minY, maxY, gridWidth, gridHeight);
            List<float> errors = _dataService.CalculateError(pontok, a0, a1);

            float nearest = errors.Min();
            float furthest = errors.Max();

            for (int i = 0; i < normpont.Count; i++)
            {
                float error = errors[i];
                Color color = GetHeatmapColor(error, nearest, furthest);
                normpont[i].PointColor = color;
            }

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.FromArgb(255, 64, 64, 64));
                float size = 20f;
                float radius = size / 2;

                foreach (var point in normpont)
                {
                    float x = Math.Clamp(point.X - radius, 0, gridWidth - size);
                    float y = Math.Clamp(point.Y - radius, 0, gridHeight - size);

                    g.FillEllipse(new SolidBrush(point.PointColor), x, y, size, size);
                }

                bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
                bitmap.Save("heatmap.bmp");
                Debug.WriteLine("Heatmap saved as heatmap.bmp");

                pictureBox.BackgroundImage = bitmap;
            }
        }

        private Color GetHeatmapColor(float error, float min, float max)
        {
            if (error == min)
                return ColorFromHSV(120, 1.0f, 1.0f);

            if (error == max)
                return ColorFromHSV(0, 1.0f, 1.0f);

            float ratio = (error - min) / (max - min);

            if (Math.Abs(min - error) < Math.Abs(max - error))
            {
                float newRatio = ratio / 0.5f;
                float hue = 120 - newRatio * 60;
                return ColorFromHSV(hue, 1.0f, 1.0f);
            }
            else
            {
                float newRatio = (ratio - 0.5f) / 0.5f;
                float hue = 60 - newRatio * 60;
                return ColorFromHSV(hue, 1.0f, 1.0f);
            }
        }

        private Color ColorFromHSV(float hue, float saturation, float value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            float f = hue / 60 - (float)Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            return hi switch
            {
                0 => Color.FromArgb(255, v, t, p),
                1 => Color.FromArgb(255, q, v, p),
                2 => Color.FromArgb(255, p, v, t),
                3 => Color.FromArgb(255, p, q, v),
                4 => Color.FromArgb(255, t, p, v),
                _ => Color.FromArgb(255, v, p, q),
            };
        }
    }


}
