using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Group : GraphObject
{
    private List<GraphObject> list;

    public Group(Frame frame,  List<GraphObject> list) : base(frame)
    {
        this.list = list;
    }

    //static Frame SetFrame(List<GraphObject> list)
    //{
    //    Frame frame = new Frame(0, 0, 0, 0);

    //    for (int i = 0; i < list.Count; i++)
    //    { 
    //        frame += list[i].Frame;
    //    }

    //    return frame;

    //}

    public override void Draw(Painter1 painter)
    {
        foreach (var graphObject in list)
        {
            graphObject.Draw(painter);

        }
    }
}