using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Controller : IController
{
    public Model model;
    private ActionController actioncontroller;
    public Controller(Model model)
    {
        
        this.model = model;
        this.actioncontroller = new ActionController(model);
    }


    
    public IModel Model { get; set; }
    public IPaint PaintController { set;  get; }
    public IAction Action { get { return actioncontroller; } } 
}