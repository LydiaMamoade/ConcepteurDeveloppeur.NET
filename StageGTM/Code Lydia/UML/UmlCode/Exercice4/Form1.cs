using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void changeCouleur()
        {
            int rouge = 0;
            if (checkBox1.Checked) rouge = 255;
            int vert = 0;
            if (checkBox1.Checked) vert = 255;
            int bleu = 0;
            if (checkBox1.Checked) bleu = 255;
            BackColor = Color.FromArgb(rouge, vert, bleu);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }
    }
}
