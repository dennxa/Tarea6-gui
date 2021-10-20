using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Location = new Point(this.Width/2 - label1.Width/2,30);
            button1.Location = new Point(this.Width/2 - button1.Width/2, this.Height-button1.Height-90);
            label2.Location = new Point(this.Width / 2 - label2.Width / 2, this.Height / 2 - label2.Height / 2);
            label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button1.Visible = false;
        }
    }
}
