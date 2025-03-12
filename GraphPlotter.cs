using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class GraphPlotter
{
    public List<PointF> DataPoints { get; private set; } = new List<PointF>();
    public PointF Offset { get; private set; } = new PointF(0, 0);
    private const int GridSpacing = 50; // Rács sűrűsége
    private const int AxisPadding = 50; // Tengelytávolság

    public GraphPlotter()
    {
        for (int i = -5; i <= 5; i++) // Adatpontok
        {
            DataPoints.Add(new PointF(i * 50, -i * i + 200)); // Parabola alakú görbe
        }
    }

    public void MoveGraph(float dx, float dy)
    {
        Offset = new PointF(Offset.X + dx, Offset.Y + dy);
    }

    public void Draw(Graphics g, Size canvasSize)
    {
        g.Clear(Color.White);
        DrawGrid(g, canvasSize);
        DrawAxes(g, canvasSize);
        DrawGraph(g, canvasSize);
    }

    private void DrawGrid(Graphics g, Size canvasSize)
    {
        Pen gridPen = new Pen(Color.LightGray, 1);
        Font gridFont = new Font("Arial", 8);
        Brush textBrush = Brushes.Black;

        // **X tengely rácsai és számai**
        int startX = (int)(-Offset.X % GridSpacing); // Rács igazítása
        int startValueX = (int)(Offset.X / GridSpacing) * GridSpacing; // Értékek számítása

        for (int x = startX; x < canvasSize.Width; x += GridSpacing)
        {
            g.DrawLine(gridPen, x, 0, x, canvasSize.Height);
            g.DrawString((startValueX + (x - startX)).ToString(), gridFont, textBrush, x + 2, canvasSize.Height - AxisPadding + 5);
        }

        // **Y tengely rácsai és számai**
        int startY = (int)(-Offset.Y % GridSpacing);
        int startValueY = (int)(Offset.Y / GridSpacing) * GridSpacing;

        for (int y = startY; y < canvasSize.Height; y += GridSpacing)
        {
            g.DrawLine(gridPen, 0, y, canvasSize.Width, y);
            g.DrawString((-startValueY - (y - startY)).ToString(), gridFont, textBrush, 5, y - 10);
        }
    }

    private void DrawAxes(Graphics g, Size canvasSize)
    {
        Pen axisPen = new Pen(Color.Black, 2);

        // X tengely mindig középen marad
        int xAxisY = (int)(canvasSize.Height / 2 + Offset.Y);
        g.DrawLine(axisPen, 0, xAxisY, canvasSize.Width, xAxisY);

        // Y tengely mindig középen marad
        int yAxisX = (int)(canvasSize.Width / 2 + Offset.X);
        g.DrawLine(axisPen, yAxisX, 0, yAxisX, canvasSize.Height);
    }

    private void DrawGraph(Graphics g, Size canvasSize)
    {
        Pen graphPen = new Pen(Color.Blue, 2);
        Brush pointBrush = Brushes.Red;

        // Adatpontok és vonalak kirajzolása
        for (int i = 0; i < DataPoints.Count - 1; i++)
        {
            PointF p1 = ToScreen(DataPoints[i], canvasSize);
            PointF p2 = ToScreen(DataPoints[i + 1], canvasSize);
            g.DrawLine(graphPen, p1, p2);
        }

        // Pontok kirajzolása
        foreach (var point in DataPoints)
        {
            PointF drawPoint = ToScreen(point, canvasSize);
            g.FillEllipse(pointBrush, drawPoint.X - 3, drawPoint.Y - 3, 6, 6);
        }
    }

    private PointF ToScreen(PointF worldPoint, Size canvasSize)
    {
        float screenX = worldPoint.X + canvasSize.Width / 2 + Offset.X;
        float screenY = canvasSize.Height / 2 - worldPoint.Y + Offset.Y;
        return new PointF(screenX, screenY);
    }
}
