
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Drawing;

namespace MyPaint
{
    public class Pencil:Shape
    {
        public List<Point> listPoint = new List<Point>();

        public override Point MinPoint
        {
            get
            {

                Point minPoint = new Point(int.MaxValue, int.MaxValue);
                foreach (Point point in listPoint)
                {
                    if (point.X < minPoint.X) minPoint.X = point.X;
                    if (point.Y < minPoint.Y) minPoint.Y = point.Y;

                }
                return minPoint;
            }
        }

        public override Point MaxPoint
        {
            get
            {
                Point maxPoint = new Point(-1, -1);
                foreach (Point point in listPoint)
                {                  
                    if (point.X > maxPoint.X) maxPoint.X = point.X;
                    if (point.Y > maxPoint.Y) maxPoint.Y = point.Y;
                }
                return maxPoint;
            }
        }
        protected override GraphicsPath GraphicsPath => throw new System.NotImplementedException();

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, WidthLine) { DashCap = DashCap.Round })
            {
                for (int i = 0; i < listPoint.Count-1; i++)
                    graphics.DrawLine(pen, listPoint[i], listPoint[i + 1]);
            }
               
        }

        public override void Move(Point distance)
        {
            for (int i = 0; i < listPoint.Count; i++)
            {
                listPoint[i] = new Point(listPoint[i].X + distance.X, listPoint[i].Y + distance.Y);
            }
        }

        public override bool IsOver(Point p)
        {
           
            foreach (Point point in listPoint)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddRectangle(new Rectangle(point.X-3,point.Y-2,7,5));
                    if (path.IsVisible(p)) return true;
                    
                }                   
            }
            return false;
        }

        public override void DrawFrame(Graphics graphics)
        {
            Point start = new Point(int.MaxValue, int.MaxValue);
            Point end = new Point(-1,-1);
           foreach(Point point in listPoint)
           {
                if (point.X < start.X) start.X = point.X;
                if (point.Y < start.Y) start.Y = point.Y;
                if (point.X > end.X) end.X = point.X;
                if (point.Y > end.Y) end.Y = point.Y;
           }

            graphics.DrawRectangle(new Pen(Color.DarkBlue, 1), start.X-1, start.Y-1, end.X - start.X+2, end.Y - start.Y+2);
            //Vẽ điểm max và min để thu phóng hình
            graphics.FillEllipse(Brushes.Blue, MinPoint.X - 3, MinPoint.Y - 3, 7, 7);
            graphics.FillEllipse(Brushes.Blue, MaxPoint.X - 3, MaxPoint.Y - 3, 7, 7);
        }
        
       
    }
}
