using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Figure : GraphObject
{
    public PropList props;
    public Figure(Frame frame, PropList props) : base(frame)
    {
        this.props = props;
    }
    public override void Draw(Painter1 painter)
    {
        props.Apply(painter);
        DrawGeometry(painter);
    }

    public abstract void DrawGeometry(Painter1 painter);
}

// Класс Line
public class Line : Figure
{
    public Line(Frame frame, PropList props) : base(frame, props)
    {

    }


    public override void DrawGeometry(Painter1 painter)
    {
        painter.DrawLine(frame.X1, frame.Y1, frame.X2, frame.Y2);                 
    }
}

public class Circle : Figure
{
    public Circle(Frame frame, PropList props) : base(frame, props)
    {
    }   
    public override void DrawGeometry(Painter1 painter)
    {

        painter.DrawCircle(frame.X1, frame.Y1, frame.X2, frame.Y2);
        
    }
}

public class Rectangle1 : Figure
{
    public Rectangle1(Frame frame, PropList props) : base(frame, props)
    {
    }
    

    public override void DrawGeometry(Painter1 painter)
    {
        painter.DrawRectangle(frame.X1, frame.Y1, frame.X2, frame.Y2);
    }
}