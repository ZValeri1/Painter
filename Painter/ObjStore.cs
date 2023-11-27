using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Objstore
{
    public List<GraphObject> objs = new List<GraphObject>();

    public void AddObject(GraphObject obj)
    {
        objs.Add(obj);
    }

    public IReadOnlyList<GraphObject> GetObjects()
    {
        return objs.AsReadOnly();
    }
}