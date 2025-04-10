using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_rabota_YS
{
    public class Square : Shape
    {

        public int X { get; set; }
        public int Y { get; set; }
        
        public float Side { get; set; }

        public Square(Point location,float side, Color outlineColor)
        {
            X = location.X;
            Y = location.Y;
            Side = side;
            Color = outlineColor;
            Bounds = new RectangleF(location.X - side / 2, location.Y - side / 2, side, side);
        }

        public RectangleF Bounds { get; set; }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color))
            {
                g.DrawRectangle(pen, Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height);
            }
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, Bounds);
            }
        }

        public override void Fill(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, Bounds);
            }
        }

        public override bool IsPointInside(PointF point)
        {
            return Bounds.Contains(point);
        }

        public override void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
            Bounds = new RectangleF(X - Side / 2, Y - Side / 2, Side, Side);
        }
        public override Shape Clone()
        {
            Square newSquare = new Square(new Point(X, Y), Side, Color);
            newSquare.FillColor = FillColor;
            return newSquare;
        }
    }
}
