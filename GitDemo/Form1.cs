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

        //eher ziemlich nutzloser Kommendar
        //das ist ein event-handler
        private void Btn_Click(object sender, EventArgs e)
        {
            Button triggerd = (Button)sender;
            MessageBox.Show($"You just clicked on Button {triggerd.Text}!");
        }

    }
}
