using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Scene : IPaint
{
    private Objstore _store;
    private readonly Painter1 _painter;

    public Scene(Objstore store, Painter1 painter)
    {
        _store = store;
        _painter = painter;
      
    }

    public void Paint()
    {
        Refresh();
        SetPort();

        foreach (GraphObject obj in _store.GetObjects())
        {
            switch (obj)
            {
                case Line line:
                    line.Draw(_painter);
                    break;
                case Circle circle:
                    circle.Draw(_painter);
                    break;
                case Rectangle1 rect:
                    rect.Draw(_painter);
                    break;
                default:
                    throw new NotSupportedException("Unsupported object type");
            }
        }
    }

    public void Refresh()
    {        
        _painter.Refresh();
    }

    public void SetPort()
    {
        _painter.SetPort(0, 0, 100, 100);
    }
}
