using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyPaint
{
    public class Square: FillableShape
    {
        
        public override  Point MinPoint
        {
            get
            {
                Point minPoint = new Point();
                if (Start.X > End.X && Start.Y > End.Y)
                    minPoint = new Point(End.X, End.Y);
                else if (Start.X > End.X && Start.Y < End.Y)
                    minPoint = new Point(End.X, Start.Y);
                else if (Start.X < End.X && Start.Y > End.Y)
                    minPoint = new Point(Start.X, End.Y);
                else
                    minPoint = Start;

                return minPoint;
            }
        }

        public override Point MaxPoint
        {
            get
            {
                Point maxPoint = new Point();
                if (Start.X > End.X && Start.Y > End.Y)
                    maxPoint = new Point(Start.X,End.Y+Start.X-End.X);
                else if (Start.X > End.X && Start.Y < End.Y)
                    maxPoint = new Point(Start.X, Start.Y + (Start.X - End.X));
                else if (Start.X < End.X && Start.Y > End.Y)
                    maxPoint = new Point(End.X, End.Y + (End.X - Start.X));
                else
                    maxPoint = new Point(End.X, Start.Y + End.X - Start.X);

                return maxPoint;
            }
        }


        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (Start.X > End.X && Start.Y > End.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(End.X, End.Y, Start.X - End.X, Start.X - End.X));
                else if (Start.X > End.X && Start.Y < End.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(End.X, Start.Y, Start.X - End.X, Start.X - End.X));
                else if (Start.X < End.X && Start.Y > End.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(Start.X, End.Y, End.X - Start.X, End.X - Start.X));
                else               
                    path.AddRectangle(new Rectangle(Start.X, Start.Y,End.X - Start.X, End.X - Start.X));
                return path;
            }
        }

       
      
        public override void Draw(Graphics graphics)
        {
            using (GraphicsPath path = GraphicsPath)
            {

                if (!Fill)
                {
                    using (Pen pen = new Pen(Color, WidthLine) { DashStyle = DashStyle })
                    {
                        graphics.DrawPath(pen, path);

                    }

                }
                else
                {
                    DrawFillBrush(graphics, path, Mybrush);

                }
            }
        }

        public override void Move(Point distance)
        {
            Start = new Point(Start.X + distance.X, Start.Y + distance.Y);
            End = new Point(End.X + distance.X, End.Y + distance.Y);
        }

        public override bool IsOver(Point p)
        {
            bool t;

            if (!Fill)
            {
                using (Pen pen = new Pen(Color, WidthLine + 7))
                {
                    t = GraphicsPath.IsOutlineVisible(p, pen);
                }
            }
            else
                t = GraphicsPath.IsVisible(p);
            return t;
        }
        public override void DrawFrame(Graphics graphics)
        {
            //Vẽ điểm max và min để thu phóng hình
            graphics.FillEllipse(Brushes.Blue, MinPoint.X -2, MinPoint.Y-2, 7, 7);
            graphics.FillEllipse(Brushes.Blue,MaxPoint.X-2,MaxPoint.Y-2, 7, 7);
        }
    }
}

