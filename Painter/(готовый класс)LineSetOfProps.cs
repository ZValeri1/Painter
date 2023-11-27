using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LineSetOfProps : SetOfProps
{
    public LineSetOfProps(Color color, float width)
    {
        Color = color;
        Width = width;
    }
    public Color Color { get; set; }
    public float Width { get; set; }
    
    public override void Apply(Painter1 painter)
    {
        painter.LineColor = Color;
        painter.LineWidht = Width;
    }
}