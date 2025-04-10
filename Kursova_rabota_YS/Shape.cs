using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_rabota_YS
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public Color FillColor { get; set; }
        public bool IsFill { get; set; }

        public abstract void Draw(Graphics g);
        public abstract void Fill(Graphics g);
        public abstract bool IsPointInside(PointF point);
        public abstract void Move(int deltaX, int deltaY);

        public abstract Shape Clone();
        protected void CloneProperties(Shape shape)
        {
            this.Color = shape.Color;
            this.FillColor = shape.FillColor;
        }
    }

}