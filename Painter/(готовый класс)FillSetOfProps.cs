using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FillSetOfProps : SetOfProps
{
    public Color FillColor { get; set; }
    public FillSetOfProps(Color fillcolor)
    {
        FillColor = fillcolor;
    }
    public override void Apply(Painter1 painter)
    {
        painter.FillColor = FillColor;
      
    }
}