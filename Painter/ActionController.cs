using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ActionController : IAction
{
    public ActionType ObjType { get { return model.Creator.CreateObjType; } set { model.Creator.CreateObjType = value; } }
    private Model model;
    public ActionController(Model model)
    {
        this.model = model;
    }

    public void MouseUp(int x, int y)
    {
        // Логика обработки действия отжатия кнопки мыши      
        ICreator creator = model.Creator;
        model.Creator.CreateObject(x, y);
        model.Paint.Refresh();
    }

    //private IModel GetModel()
    //{
    //    MyModel GetObjType1 = new MyModel();
    //    GetObjType1.GetTypeOfFigure = GetObjType;
    //    return new MyModel();
    //}
}
