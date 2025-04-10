namespace Kursova_rabota_YS
{
    partial class CircleForm
    {
       
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.areacircle = new System.Windows.Forms.Button();
            this.drawcircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Лице";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "0.00";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // areacircle
            // 
            this.areacircle.Location = new System.Drawing.Point(51, 297);
            this.areacircle.Name = "areacircle";
            this.areacircle.Size = new System.Drawing.Size(87, 49);
            this.areacircle.TabIndex = 4;
            this.areacircle.Text = "Изчисти лицето";
            this.areacircle.UseVisualStyleBackColor = true;
            this.areacircle.Click += new System.EventHandler(this.areacircle_Click);
            // 
            // drawcircle
            // 
            this.drawcircle.Location = new System.Drawing.Point(272, 297);
            this.drawcircle.Name = "drawcircle";
            this.drawcircle.Size = new System.Drawing.Size(89, 49);
            this.drawcircle.TabIndex = 5;
            this.drawcircle.Text = "Начертай фигурата";
            this.drawcircle.UseVisualStyleBackColor = true;
            this.drawcircle.Click += new System.EventHandler(this.drawcircle_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 421);
            this.Controls.Add(this.drawcircle);
            this.Controls.Add(this.areacircle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CircleForm";
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button areacircle;
        private System.Windows.Forms.Button drawcircle;
    }
}