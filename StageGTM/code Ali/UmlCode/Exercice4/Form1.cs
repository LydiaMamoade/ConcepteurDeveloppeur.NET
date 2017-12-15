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

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCouleur();
        }

        private void ChangeCouleur()
        {
            int rouge = 0;
            if (checkBox1.Checked) rouge = 255;
            int vert = 0;
            if (checkBox2.Checked) vert = 255;
            int bleu = 0;
            if (checkBox3.Checked) bleu = 255;
            BackColor = Color.FromArgb(rouge, vert, bleu);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCouleur();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCouleur();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
