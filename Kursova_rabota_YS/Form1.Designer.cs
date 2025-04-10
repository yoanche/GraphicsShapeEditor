namespace Kursova_rabota_YS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_move = new System.Windows.Forms.Button();
            this.pic_color_btn = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_redo = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_move);
            this.panel1.Controls.Add(this.pic_color_btn);
            this.panel1.Controls.Add(this.btn_undo);
            this.panel1.Controls.Add(this.btn_redo);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 114);
            this.panel1.TabIndex = 0;
            // 
            // btn_move
            // 
            this.btn_move.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_move.Location = new System.Drawing.Point(775, 24);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(74, 32);
            this.btn_move.TabIndex = 11;
            this.btn_move.Text = "Move";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // pic_color_btn
            // 
            this.pic_color_btn.BackColor = System.Drawing.Color.White;
            this.pic_color_btn.Location = new System.Drawing.Point(159, 40);
            this.pic_color_btn.Name = "pic_color_btn";
            this.pic_color_btn.Size = new System.Drawing.Size(47, 39);
            this.pic_color_btn.TabIndex = 10;
            this.pic_color_btn.UseVisualStyleBackColor = false;
            // 
            // btn_undo
            // 
            this.btn_undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_undo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_undo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_undo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_undo.Location = new System.Drawing.Point(891, 26);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(78, 31);
            this.btn_undo.TabIndex = 9;
            this.btn_undo.Text = "Undo";
            this.btn_undo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_redo
            // 
            this.btn_redo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_redo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_redo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_redo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_redo.Location = new System.Drawing.Point(891, 63);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(78, 31);
            this.btn_redo.TabIndex = 8;
            this.btn_redo.Text = "Redo";
            this.btn_redo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_redo.UseVisualStyleBackColor = true;
            this.btn_redo.Click += new System.EventHandler(this.btn_redo_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.Location = new System.Drawing.Point(775, 63);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 31);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.btn_triangle);
            this.panel3.Controls.Add(this.btn_square);
            this.panel3.Controls.Add(this.btn_circle);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(224, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 88);
            this.panel3.TabIndex = 3;
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Image = global::Kursova_rabota_YS.Properties.Resources.bucket;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_fill.Location = new System.Drawing.Point(97, 10);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(78, 65);
            this.btn_fill.TabIndex = 6;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_triangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_triangle.ForeColor = System.Drawing.Color.White;
            this.btn_triangle.Image = global::Kursova_rabota_YS.Properties.Resources.Без_име31;
            this.btn_triangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_triangle.Location = new System.Drawing.Point(433, 10);
            this.btn_triangle.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(78, 65);
            this.btn_triangle.TabIndex = 5;
            this.btn_triangle.Text = "Triangle";
            this.btn_triangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_square
            // 
            this.btn_square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_square.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_square.ForeColor = System.Drawing.Color.White;
            this.btn_square.Image = global::Kursova_rabota_YS.Properties.Resources.rectangle;
            this.btn_square.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_square.Location = new System.Drawing.Point(349, 10);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(78, 65);
            this.btn_square.TabIndex = 4;
            this.btn_square.Text = "Square";
            this.btn_square.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_square.UseVisualStyleBackColor = false;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_circle.ForeColor = System.Drawing.Color.White;
            this.btn_circle.Image = global::Kursova_rabota_YS.Properties.Resources.circle;
            this.btn_circle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_circle.Location = new System.Drawing.Point(265, 10);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(78, 65);
            this.btn_circle.TabIndex = 3;
            this.btn_circle.Text = "Circle";
            this.btn_circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_circle.UseVisualStyleBackColor = false;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::Kursova_rabota_YS.Properties.Resources.color;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_color.Location = new System.Drawing.Point(13, 10);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(78, 65);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Image = global::Kursova_rabota_YS.Properties.Resources.eraser;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(181, 10);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(78, 65);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 754);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 35);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1005, 789);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 69);
            this.label1.TabIndex = 12;
            this.label1.Text = "Yoana\'s project";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 789);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_redo;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button pic_color_btn;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Label label1;
    }
}

