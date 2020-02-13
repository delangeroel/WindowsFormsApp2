using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dit maakt het scherm onzichtbaar waardoor hij verdwijnt.
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Rood";
            label1.ForeColor = Color.Red;
            textBox1.Text = "Een rode tekst die doorloopt over meerdere regels door eigenschap multiline YES te maken" ;
            textBox1.ForeColor = Color.Red;

        }
    }
}
