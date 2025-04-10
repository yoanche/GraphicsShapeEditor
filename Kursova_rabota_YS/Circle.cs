using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_rabota_YS
{
    public class Circle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public float Radius { get; set; }

       

        public Circle(Point center, float radius, Color outlineColor)
        {
            X = center.X;
            Y = center.Y;
            Radius = radius;
            Color = outlineColor;
            Center = center;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color))
            {
                g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }
        }
        public override void Fill(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                g.FillEllipse(brush, new RectangleF(X - Radius, Y - Radius, Radius * 2, Radius * 2));
            }
        }
        public PointF Center { get; set; }

        public override bool IsPointInside(PointF point)
        {
            float distance = (float)Math.Sqrt(Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2));
            return distance <= Radius; 
        }


        public override void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
            Center = new PointF(X, Y);
        }

        public override Shape Clone()
        {
            Circle newCircle = new Circle(new Point(X, Y), Radius, Color);
            newCircle.FillColor = FillColor;
            return newCircle;
        }
    }
}
