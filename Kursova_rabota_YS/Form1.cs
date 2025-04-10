using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Policy;

namespace Kursova_rabota_YS
{
    public partial class Form1 : Form
    {
     
        private Color new_color = Color.White;
        private bool isDragging = false;
        private bool isMovingEnabled = false;
        private Point lastMousePosition; 
        
        private readonly Stack<List<Shape>> undoStack = new Stack<List<Shape>>();
        private readonly Stack<List<Shape>> redoStack = new Stack<List<Shape>>();
        
        private List<Shape> shapes = new List<Shape>();
        private enum ShapeEnum { None, Circle, Triangle, Square };
        private ShapeEnum selectedShape = ShapeEnum.None;

        private Shape selectedShape1;

        Pen p = new Pen(Color.Black);
        ColorDialog cd = new ColorDialog();

        public float circleRadius { get; set; }
        public float squareSide { get; set; }

        public float trsideA {  get; set; }
        public float trsideB { get; set; }
        public float trsideC { get; set; }



        public Form1()
        {
            InitializeComponent();
           
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedShape != ShapeEnum.None && isMovingEnabled == false)
            {
                if (!isFilling)
                {
                    CreateShape(e.Location);
                }
                else
                {
                    FillShape(e.Location);
                    isFilling = true; 
                }

                pic.Invalidate(); 
            }
        }

        private void CreateShape(Point coordinates)
        {
            switch (selectedShape)
            {
                case ShapeEnum.Circle:
                    Circle circle = new Circle(coordinates, circleRadius, new_color);
                    shapes.Add(circle);
                    selectedShape1 = circle;
                    break;
                case ShapeEnum.Triangle:
                    float height = (float)Math.Sqrt((trsideB * trsideB) - ((trsideA / 2) * (trsideA / 2)));

                    Triangle triangle = new Triangle(
                        new PointF(coordinates.X, coordinates.Y - 40), 
                        new PointF(coordinates.X - (float)(trsideA / 2), coordinates.Y + height), 
                        new PointF(coordinates.X + (float)(trsideA / 2), coordinates.Y + height), 
                        new_color);
                    shapes.Add(triangle);
                    selectedShape1 = triangle;
                    break;
                case ShapeEnum.Square:
                    Square square = new Square(coordinates, squareSide , new_color);
                    shapes.Add(square);
                    selectedShape1 = square;
                    break;
            }
            AddToUndoStack();
        }

        private void FillShape(Point coordinates)
        {
            foreach (var shape in shapes)
            {
                if (shape.IsPointInside(coordinates))
                {
                    shape.FillColor = new_color;
                    shape.Fill(pic.CreateGraphics());
                    break;
                }
            }
            AddToUndoStack();
            isMovingEnabled = false;
        }
        private void shape_Click(object sender, EventArgs e)
        {
        
            selectedShape1 = (Shape)sender;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = new Bitmap(pic.Width, pic.Height);
                pic.DrawToBitmap(btm, new Rectangle(0, 0, pic.Width, pic.Height));
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private bool isFilling=false;
     
        private void btn_fill_Click(object sender, EventArgs e)
        {
            isFilling = true;
            isMovingEnabled = false;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            isFilling = false;
            isMovingEnabled = false;

            shapes.Clear();
            pic.Invalidate();
            undoStack.Clear();
            redoStack.Clear();

        }
        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                if (shapes.Count > 0)
                {
                    shapes.RemoveAt(shapes.Count-1);
                    pic.Invalidate();
                }

                var currentState = new List<Shape>(shapes);
                redoStack.Push(currentState);
                shapes = undoStack.Pop();

                pic.Invalidate();
            }

        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                var currentState = new List<Shape>(shapes);
                undoStack.Push(currentState);

                shapes = redoStack.Pop();

                pic.Invalidate();
            }
        }
        private void AddToUndoStack()
        {
            var curState = new List<Shape>();
            foreach (var shape in shapes)
            {
                curState.Add(shape.Clone());
            }
            undoStack.Push(curState);
            redoStack.Clear();
        }


        private void btn_color_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                new_color = cd.Color;
                pic_color_btn.BackColor = cd.Color;
                p.Color = cd.Color;
            }
            isMovingEnabled = false;
        }
        private void btn_move_Click(object sender, EventArgs e)
        {
            isMovingEnabled = true;
           
        }
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && isMovingEnabled)
            {
                
                foreach (var shape in shapes)
                {
                    if (shape.IsPointInside(e.Location))
                    {
                        selectedShape1 = shape;
                        isDragging = true;
                        lastMousePosition = e.Location;
                        break;
                    }
                }
            }
        }

            private void pic_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (isDragging && isMovingEnabled && selectedShape1 != null)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;
                selectedShape1.Move(deltaX, deltaY);
                lastMousePosition = e.Location;
                pic.Invalidate();
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMovingEnabled)
            {
                isDragging = false;
            }
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeEnum.Circle;
            isFilling = false;
            isMovingEnabled = false;

            CircleForm circleForm = new CircleForm();
            circleForm.Owner = this;
            circleForm.ShowDialog();
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeEnum.Square;
            isFilling = false;
            isMovingEnabled = false;

            SquareForm squareForm = new SquareForm();
            squareForm.Owner = this;
            squareForm.ShowDialog();
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeEnum.Triangle;
            isFilling = false;
            isMovingEnabled = false;

            TriangleForm triangleForm = new TriangleForm();
            triangleForm.Owner = this;
            triangleForm.ShowDialog();

        }
    }
}