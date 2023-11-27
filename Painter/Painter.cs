using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Painter1
{
    private Graphics graphics;
    private int x1, y1, x2, y2;
    //private DashStyle dashStyle;
    //private Brush brush;

    public Color LineColor { set; get; }
    public Color FillColor { set; get; }
    public float LineWidht { set; get; }

    
    public Painter1(Graphics graphics)
    {
        this.graphics = graphics;
    }

    public void SetPort(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public void Refresh()
    {
        graphics.Clear(Color.White);
    }

    public void SetColor(Color color)
    {
        LineColor = color;
    }

    public void SetLineWidth(int width)
    {
        LineWidht = width;
    }
    

    public void DrawLine(int x1, int y1, int x2, int y2)
    {
        using (Pen pen = new Pen(LineColor, LineWidht))
        {
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }
    }

    //public void DrawLineDashed(int x1, int y1, int x2, int y2)
    //{
    //    using (Pen pen = new Pen(LineColor, LineWidht))
    //    {
    //        pen.DashStyle = DashStyle.Dash;
    //        graphics.DrawLine(pen, x1, y1, x2, y2);
    //    }
    //}

    public void DrawCircle(int x1, int x2, int y1, int y2)
    {
        using (Pen pen = new Pen(LineColor, LineWidht))
        {
            graphics.FillEllipse(new SolidBrush(FillColor), x1, x2, y1, y2);
            graphics.DrawEllipse(pen, x1, x2, y1, y2);
        }
    }

    public void DrawRectangle(int x1, int x2, int y1, int y2)
    {
        using (Pen pen = new Pen(LineColor, LineWidht))
        {
            graphics.FillRectangle(new SolidBrush(FillColor), x1, x2, y1, y2);
            graphics.DrawRectangle(pen, x1, x2, y1, y2);
        }
    }
}