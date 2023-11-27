using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IAction
{
    void MouseUp(int x, int y);
    ActionType ObjType { get;  set; }
}