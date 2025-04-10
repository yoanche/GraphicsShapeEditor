namespace Kursova_rabota_YS
{
    partial class SquareForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.areatriangle = new System.Windows.Forms.Button();
            this.drawsquare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // areatriangle
            // 
            this.areatriangle.Location = new System.Drawing.Point(62, 283);
            this.areatriangle.Name = "areatriangle";
            this.areatriangle.Size = new System.Drawing.Size(87, 55);
            this.areatriangle.TabIndex = 0;
            this.areatriangle.Text = "Изчисли лицето";
            this.areatriangle.UseVisualStyleBackColor = true;
            this.areatriangle.Click += new System.EventHandler(this.areasquare_Click);
            // 
            // drawsquare
            // 
            this.drawsquare.Location = new System.Drawing.Point(237, 283);
            this.drawsquare.Name = "drawsquare";
            this.drawsquare.Size = new System.Drawing.Size(89, 55);
            this.drawsquare.TabIndex = 1;
            this.drawsquare.Text = "Начертай фигурата";
            this.drawsquare.UseVisualStyleBackColor = true;
            this.drawsquare.Click += new System.EventHandler(this.drawsquare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "страна а";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Лице";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "0.00";
            // 
            // SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawsquare);
            this.Controls.Add(this.areatriangle);
            this.Name = "SquareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Square";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button areatriangle;
        private System.Windows.Forms.Button drawsquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}