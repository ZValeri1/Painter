using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IController
{
    IModel Model { set; }
    IPaint PaintController { get; }
    IAction Action { get; }
}