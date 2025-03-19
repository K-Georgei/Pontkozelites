using ScottPlot.Plottables;
using ScottPlot.WinForms;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozelites
{
    public class PlotService
    {
        private readonly FormsPlot _formsPlot;

        public PlotService(FormsPlot formsPlot)
        {
            _formsPlot = formsPlot;
        }

        public void RefreshGraph(List<Pont2D> pontok)
        {
            _formsPlot.Plot.Clear();

            if (pontok.Count > 1)
            {
                foreach (Pont2D p in pontok)
                {
                    _formsPlot.Plot.Add.Scatter(p.X, p.Y);
                }
            }
            _formsPlot.Refresh();
        }

        public LinePlot CalculateLinRegression(float minX, float maxX, float a0, float a1)
        {
            double startX = minX;
            double endX = maxX;
            double startY = a1 * minX + a0;
            double endY = a1 * maxX + a0;

            return new LinePlot()
            {
                Start = new Coordinates((float)startX, (float)startY),
                End = new Coordinates((float)endX, (float)endY),
            };
        }
    }


}
