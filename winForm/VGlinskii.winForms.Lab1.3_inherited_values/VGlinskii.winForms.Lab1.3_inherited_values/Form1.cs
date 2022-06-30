using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VGlinskii.winForms.Lab1._3_inherited_values
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 0),
            new Point(0, this.Height),
            new Point(this.Width, 0) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    
