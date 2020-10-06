using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyPaint
{
    public class Line:Shape
    {

        public override Point MinPoint
        {
            get
            {
                Point minPoint = new Point();
                if (Start.X > End.X)
                {
                    minPoint.X = End.X;                 
                }
                else
                {
                    minPoint.X = Start.X;
                }

                if (Start.Y > End.Y)
                {
                    minPoint.Y = End.Y;
                }
                else
                {
                    minPoint.Y = Start.Y;
                }
                return minPoint;
            }
        }

        public override Point MaxPoint
        {
            get
            {
                Point maxPoint = new Point();
                if (Start.X > End.X)
                {
                    maxPoint.X = Start.X;
                }
                else
                {
                    maxPoint.X = End.X;
                }

                if (Start.Y > End.Y)
                {
                    maxPoint.Y = Start.Y;
                }
                else
                {
                    maxPoint.Y = End.Y;
                }

                return maxPoint;
            }
        }
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddLine(Start, End);
                return path;
            }
        }
       
        public override void Draw(Graphics graphics)
        {
            using (GraphicsPath gr = GraphicsPath)
            {
                using (Pen pen = new Pen(Color, WidthLine) { DashStyle = DashStyle })
                {
                    graphics.DrawPath(pen, gr);
                }
            }
        }
        public override bool IsOver(Point p)
        {
            bool res;          
                using (Pen pen = new Pen(Color, WidthLine+5))
                {
                    res = GraphicsPath.IsOutlineVisible(p,pen);
                }
            
            return res;
        }

        public override void Move(Point distance)
        {
            this.Start = new Point(Start.X + distance.X, Start.Y + distance.Y);
            this.End = new Point(End.X + distance.X, End.Y + distance.Y);
        }
        public override void DrawFrame(Graphics graphics)
        {
                     
            using (Pen pen = new Pen(Color.DarkBlue, 1) { DashStyle = DashStyle.Dash })
            {
                 graphics.DrawRectangle(pen, MinPoint.X, MinPoint.Y, MaxPoint.X - MinPoint.X, MaxPoint.Y - MinPoint.Y);            
            }

            graphics.FillEllipse(Brushes.Blue, MinPoint.X - 3, MinPoint.Y - 3, 7, 7);
            graphics.FillEllipse(Brushes.Blue, MaxPoint.X - 3, MaxPoint.Y - 3, 7, 7);
        }

      
    }
}
