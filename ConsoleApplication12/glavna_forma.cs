using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication1;

namespace ConsoleApplication12
{
    public partial class glavna_forma : Form
    {
        private QuadraticEquation qe;

        public glavna_forma()
        {
            InitializeComponent();
            double a = (double)numericUpDown4.Value;
            double b = (double)numericUpDown5.Value;
            double c = (double)numericUpDown6.Value;
            qe = new QuadraticEquation(a, b, c);
            functionPanel1.Function = new DrawingQuadraticEquation.Function(qe.Y);
            functionPanel1.Invalidate();
        }

        private void fillResult() {
            textBox4.Text = qe.Discriminant.ToString();
            textBox5.Text = qe.Roots[0].ToString();
            textBox6.Text = qe.Roots[1].ToString();
        }

        private void readValues() {
            qe.A = (double)numericUpDown4.Value;
            qe.B = (double)numericUpDown5.Value;
            qe.C = (double)numericUpDown6.Value;
            functionPanel1.Invalidate();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readValues();
            fillResult();
        }

        private void glavna_forma_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            readValues();
            fillResult();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            readValues();
            fillResult();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            readValues();
            fillResult();
        }

        private void functionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
