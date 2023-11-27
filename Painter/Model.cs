using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Model : IModel
{
    private Objstore objstore;
    private Scene scene;
    private Factory factory;
    private Painter1 painter;
    //Factory factory1 = new Factory();
    public Model()
    {
        objstore = new Objstore();
        factory = new Factory();
        scene = new Scene(objstore, painter);
    }

    //public Factory GetFactory
    //{
    //    get { return factory; }
    //}
    public ActionType ObjTypee { set; get; }
    public IPaint Paint { set; get; }
    public ICreator Creator { set; get; }    
}