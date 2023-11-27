using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{

    public partial class Form1 : Form
    {
        private Controller controller;
        //private Model model;
        

        public Form1()
        {
            Model model = new Model();
            InitializeComponent();
            controller = new Controller(model);           
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //controller.mouseup
        }


        private void button1_Click(object sender, EventArgs e)
        {
            controller.Action.ObjType = ActionType.Line;

            //painter.SetPort(0, 0, 100, 100);

            //Factory factory = new Factory();


            //GraphObject line = factory.CreateObject(0, 0, ActionType.Line); 

            //if (line is Line)
            //{

            //    ((Line)line).Draw(painter);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.Action.ObjType = ActionType.Rectangle;
            //painter.SetPort(0, 0, 100, 100);

            //Factory factory = new Factory(); 

            
            //GraphObject rectangle = factory.CreateObject(0, 0, ActionType.Rectangle); 
            //if (rectangle is Rectangle1)
            //{
                
            //    ((Rectangle1)rectangle).Draw(painter);
            //}
            //rectangle.Draw(painter);           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            controller.Action.ObjType = ActionType.Circle;
            //painter.SetPort(0, 0, 100, 100);
            //Factory factory = new Factory();
            //GraphObject circle = factory.CreateObject(0, 0, ActionType.Circle);
            //if (circle is Circle)
            //{
               
            //    ((Circle)circle).Draw(painter);
            //}
            //circle.Draw(painter);
            
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
    
}
