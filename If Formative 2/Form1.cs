using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Formative_2
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Pen drawPen = new Pen(Color.White, 10);
            Graphics formGraphics = this.CreateGraphics();

            if (colorTextbox.Text =="g")
            {
                drawPen = new Pen(Color.Green, 10);
            }
            else if (colorTextbox.Text == "r") 
            {
                drawPen = new Pen(Color.Red, 10);
            }

            if (shapeTextbox.Text == "circle")
            {
                formGraphics.Clear(Color.White);
                formGraphics.DrawEllipse(drawPen, 50, 100, 100, 100);
            }

            else if (shapeTextbox.Text =="rectangle")
            {
                formGraphics.Clear(Color.White);
                formGraphics.DrawRectangle(drawPen, 50, 100, 120, 100);
            }
        }
    }
}
