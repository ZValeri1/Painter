using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PropList : List<SetOfProps>
{
    public  void Apply(Painter1 painter)
    {
        for (int i = 0; i < this.Count; i++)
        {
            this[i].Apply(painter);
        }
    }
}