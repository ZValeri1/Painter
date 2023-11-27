using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Frame
{
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    public Frame(int x1, int y1, int x2, int y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public static Frame operator +(Frame frame1, Frame frame2)
    {
        int minX = Math.Min(frame1.X1, frame2.X1);
        int minY = Math.Min(frame1.Y1, frame2.Y1);
        int maxX = Math.Max(frame1.X2, frame2.X2);
        int maxY = Math.Max(frame1.Y2, frame2.Y2);

        return new Frame(minX, minY, maxX, maxY);
    }
}