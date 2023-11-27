using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICreator
{ 
    GraphObject CreateObject(int x, int y);
    ActionType CreateObjType { set; get; }
}
