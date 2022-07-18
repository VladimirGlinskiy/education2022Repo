using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VGlinskii.winForm.RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { 
            Label label = new Label();
                label.Location = new System.Drawing.Point(16, 96);
                label.Size = new System.Drawing.Size(32, 23);
                label.Name = "labelll";
                label.TabIndex = 2;
                label.Text = "PIN2";
            
            groupBox1.Controls.Add(label);

            TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(96, 96);
                textBox.Size = new System.Drawing.Size(184, 20);
                textBox.Name = "textboxx";
                textBox.TabIndex = 1;
                textBox.Text = ""; 

            groupBox1.Controls.Add(textBox);
            }
            else {
                int elementsCounter;
                elementsCounter = groupBox1.Controls.Count;
                while (elementsCounter > 4) {
                    groupBox1.Controls.RemoveAt(elementsCounter-1);
                    elementsCounter -= 1;
                }
            }
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
