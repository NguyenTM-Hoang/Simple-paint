using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyPaint
{
    public class Rectangl: FillableShape
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
                 if(Start.X>End.X && Start.Y>End.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(End.X,End.Y,  Start.X-End.X,  Start.Y- End.Y ));
                 else if( Start.X> End.X && Start.Y< End.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(End.X, Start.Y, Start.X - End.X, End.Y-Start.Y));
                 else if (Start.X <End.X && Start.Y > End.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(Start.X, End.Y, End.X-Start.X, Start.Y- End.Y));
                 else
                path.AddRectangle(new System.Drawing.Rectangle(Start.X, Start.Y, End.X - Start.X,End.Y-Start.Y));
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
            graphics.FillEllipse(Brushes.Blue, Start.X-3, Start.Y-3, 7, 7);
            graphics.FillEllipse(Brushes.Blue, End.X-3, End.Y-3, 7, 7);
            
        }
    }
}
