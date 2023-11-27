using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Factory : ICreator
{
    PropList props = new PropList();
    public ActionType CreateObjType{ set; get; }
    public Objstore store = new Objstore();

    public GraphObject CreateObject(int x, int y)
    {
        switch (CreateObjType)
        {
            case ActionType.Rectangle:
                Frame frame1 = new Frame(x, y, 100, 100);
                props.Add(new LineSetOfProps(Color.Red, 5));
                props.Add(new FillSetOfProps(Color.Black));
                Rectangle1 rect = new Rectangle1(frame1, props);
                store.AddObject(rect);
                return rect;
            case ActionType.Circle:
                Frame frame2 = new Frame(x, y, 100, 100);
                props.Add(new LineSetOfProps(Color.Green, 3));
                props.Add(new FillSetOfProps(Color.Orange));
                Circle circle = new Circle(frame2, props);
                store.AddObject(circle);
                CreateObjType = ActionType.Circle;
                return circle;
            case ActionType.Line:
                Frame frame3 = new Frame(x, y, 100, 100);
                props.Add(new LineSetOfProps(Color.Blue, 5));
                Line line = new Line(frame3, props);
                store.AddObject(line);
                CreateObjType = ActionType.Line;
                return line;
            default:
                throw new NotSupportedException("Unsupported object type");
        }
    }
}