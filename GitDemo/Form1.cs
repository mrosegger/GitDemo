using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You just clicked on button 1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You just clicked on button 2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You just clicked on button 3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You just clicked on button 4");
        }
    }
}
