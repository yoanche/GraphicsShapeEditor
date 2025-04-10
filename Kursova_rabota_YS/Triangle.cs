using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_rabota_YS
{
    public class Triangle : Shape
    {
        public PointF Point1 { get; set; }
        public PointF Point2 { get; set; }
        public PointF Point3 { get; set; }

        public Triangle(PointF point1, PointF point2, PointF point3, Color outlineColor)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Color = outlineColor;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color))
            {
                g.DrawPolygon(pen, new PointF[] { Point1, Point2, Point3 });
            }
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                g.FillPolygon(brush, new PointF[] { Point1, Point2, Point3 });
            }
        }

        public override void Fill(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                g.FillPolygon(brush, new PointF[] { Point1, Point2, Point3 });
            }
        }

        public override bool IsPointInside(PointF point)
        {
            float x1 = Point1.X;
            float y1 = Point1.Y;
            float x2 = Point2.X;
            float y2 = Point2.Y;
            float x3 = Point3.X;
            float y3 = Point3.Y;

            float alpha = ((y2 - y3) * (point.X - x3) + (x3 - x2) * (point.Y - y3)) /
                          ((y2 - y3) * (x1 - x3) + (x3 - x2) * (y1 - y3));
            float beta = ((y3 - y1) * (point.X - x3) + (x1 - x3) * (point.Y - y3)) /
                         ((y2 - y3) * (x1 - x3) + (x3 - x2) * (y1 - y3));
            float gamma = 1 - alpha - beta;

            return alpha > 0 && beta > 0 && gamma > 0;
        }
        public override void Move(int deltaX, int deltaY)
        {
            Point1 = new PointF(Point1.X + deltaX, Point1.Y + deltaY);
            Point2 = new PointF(Point2.X + deltaX, Point2.Y + deltaY);
            Point3 = new PointF(Point3.X + deltaX, Point3.Y + deltaY);
        }
        public override Shape Clone()
        {
            Triangle newTriangle = new Triangle(Point1, Point2, Point3, Color);
            newTriangle.FillColor = FillColor;
            return newTriangle;
        }
    }
}
