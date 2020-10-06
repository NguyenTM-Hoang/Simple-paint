using System;
using System.Drawing.Drawing2D;
using System.Drawing;
namespace MyPaint
{
    public abstract class Shape
    {
        //Properties
        public Point Start { get; set; }
        public Point End { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }
        public DashStyle DashStyle { get; set; } = DashStyle.Solid;
        public float WidthLine { get; set; }
        public bool Fill { get; set; }
        public string Mybrush { get; set; }
        public  abstract Point MinPoint { get; }
        public abstract Point MaxPoint { get; }

        protected abstract GraphicsPath GraphicsPath { get; }
        public abstract void Draw(Graphics graphics);
        public abstract void Move(Point distance);
        public abstract bool IsOver(Point p);
        public abstract void DrawFrame(Graphics graphics);
        public virtual void ZoomInOut(Point point)
        {
            End = new Point(End.X+point.X,End.Y+ point.Y);
        }
        public virtual void DrawFillBrush(Graphics graphics, GraphicsPath path, string mybrush) { }
     
    }
}
