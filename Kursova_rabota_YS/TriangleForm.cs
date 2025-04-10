using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_rabota_YS
{

    public partial class TriangleForm : Form
    {
        private float sideA;
        private float sideB;
        private float sideC;

        public TriangleForm()
        {
            InitializeComponent();
        }

        private void areatriangle_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out sideA) && float.TryParse(textBox2.Text, out sideB) && float.TryParse(textBox3.Text, out sideC))
            {
                double p = (sideA + sideB + sideC) / 2;
                double area = Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
                label5.Text = $"{area:F2}";
            }
        }

        private void drawtriangle_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out sideA) && float.TryParse(textBox2.Text, out sideB) && float.TryParse(textBox3.Text, out sideC))
            {
                Form1 Form1 = (Form1)this.Owner;
                Form1.trsideA = sideA;
                Form1.trsideB = sideB;
                Form1.trsideC = sideC;
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
