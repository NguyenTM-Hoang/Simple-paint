using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace MyPaint
{
    public class Curve: Shape
    {
        public List<Point> ListPoint { get; set; } = new List<Point>();
        public bool isZooming ;
        int a;
        int b;
        public override Point MinPoint
        {
            get
            {
                Point minPoint = new Point();
                 minPoint.X = int.MaxValue;
                minPoint.Y = int.MaxValue;
                for (int i = 0; i < ListPoint.Count; i++)
                {
                    if (ListPoint[i].X < minPoint.X)
                    {
                        minPoint.X = ListPoint[i].X;
                        a = i;
                    }
                    if (ListPoint[i].Y < minPoint.Y)
                    {
                        minPoint.Y = ListPoint[i].Y;
                        b = i;
                    }

                }
                return minPoint;
            }
        }

        public override Point MaxPoint
        {
            get
            {
                Point maxPoint = new Point();
                maxPoint.X = -1;
                maxPoint.Y = -1;
                foreach (Point p in ListPoint)
                {
                    if (p.X > maxPoint.X)
                        maxPoint.X = p.X;
                    if (p.Y > maxPoint.Y)
                        maxPoint.Y = p.Y;
                }
                return maxPoint;
            }
        }

        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                
                    path.AddCurve(ListPoint.ToArray());
                return path;
            }
        }

        public override void Draw(Graphics graphics)
        {
            using (GraphicsPath path = GraphicsPath)
            { 
                 using (Pen pen = new Pen(Color, WidthLine) { DashStyle = DashStyle })
                 {
                     graphics.DrawPath(pen, path);

                 }           
            }
        }


        public override void Move(Point distance)
        {
            for (int i = 0; i < ListPoint.Count; i++)
            {
                ListPoint[i] = new Point(ListPoint[i].X + distance.X, ListPoint[i].Y + distance.Y);
            }
        }

        public override bool IsOver(Point p)
        {
            bool t;
            using (Pen pen = new Pen(Color, WidthLine + 7))
            {
                t = GraphicsPath.IsOutlineVisible(p, pen);
            }
            return t;
        }
        public override void DrawFrame(Graphics graphics)
        {
          
            using (Pen pen = new Pen(Color.DarkBlue, 1) { DashStyle = DashStyle.Dash })
            {
                graphics.DrawRectangle(pen, new Rectangle(this.MinPoint.X, MinPoint.Y, MaxPoint.X - MinPoint.X, MaxPoint.Y - MinPoint.Y));
            }

            graphics.FillEllipse(Brushes.Blue, MinPoint.X - 3, MinPoint.Y - 3, 7, 7);
            graphics.FillEllipse(Brushes.Blue, MaxPoint.X - 3, MaxPoint.Y - 3, 7, 7);
        }
        public override void ZoomInOut(Point p)
        {
            Point t = new Point(p.X / 2, p.Y / 2);
            int j = 0;
            for (int i = 0; i < ListPoint.Count; i++)
            {
                j++;
                if (i == a)
                    ListPoint[i] = new Point(ListPoint[i].X, ListPoint[i].Y + t.Y * (j));
                else
                    if (i == b)
                    ListPoint[i] = new Point(ListPoint[i].X + t.X * (j), ListPoint[i].Y);
                else
                    ListPoint[i] = new Point(ListPoint[i].X + t.X * (j), ListPoint[i].Y + t.Y * (j));
            }
        }
    }
}

