using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_rabota_YS
{
    public partial class SquareForm : Form
    {
        private float side;

        public SquareForm()
        {
            InitializeComponent();
        }

        private void areasquare_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out side))
            {
                double area = side * side;
                label3.Text = $"{area:F2}";
            }
        }

        private void drawsquare_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out side))
            {
                Form1 Form1 = (Form1)this.Owner;
                Form1.squareSide = side;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid radius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
