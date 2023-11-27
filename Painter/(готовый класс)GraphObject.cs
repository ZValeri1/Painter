using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class GraphObject
{
    protected Frame frame;


    public GraphObject(Frame frame)
    {
        this.frame = frame;

    }

    public abstract void Draw(Painter1 painter);
}