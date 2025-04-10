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
    public partial class CircleForm : Form
    {
        private float radius;

        public CircleForm()
        {
            InitializeComponent();
            drawcircle.Click += new EventHandler(drawcircle_Click);
        }
        private void areacircle_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out radius))
            {
                double area = Math.PI * radius * radius;
                label3.Text = $"{area:F2}";
            }
        }
  

        private void drawcircle_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out radius))
            {
                Form1 Form1 = (Form1)this.Owner; 
                Form1.circleRadius = radius; 
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
