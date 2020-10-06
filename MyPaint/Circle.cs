using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyPaint
{
    public class Circle:FillableShape
    {
        
        public int Diameter;
        //private Point minPoint;
        //private Point maxPoint;

        public override Point MinPoint
        {
            get
            {
               
                Point minPoint = new Point(Start.X, Start.Y);
                if ((Start.X > End.X && Start.Y > End.Y))
                {
                    minPoint.X = Start.X + Diameter;
                    minPoint.Y = Start.Y + Diameter;
                }
                else if (Start.X > End.X && End.Y > Start.Y)
                {
                    minPoint.X =MaxPoint.X+ Diameter;
                    minPoint.Y =MaxPoint.Y +Diameter;
                }
                return minPoint;
            }
        }
        public override Point MaxPoint
        {
            get
            {

                Point maxPoint = new Point();
               
                if (Start.X > End.X && Start.Y > End.Y)
                {
                    maxPoint.X = MinPoint.X - Diameter;
                    maxPoint.Y = MinPoint.Y - Diameter;
                }
                else if(Start.X > End.X && End.Y > Start.Y)
                {
                    maxPoint = Start;
                }
                else
                {
                    maxPoint.X = MinPoint.X + Diameter;
                    maxPoint.Y = MinPoint.Y + Diameter;
                }
                    return maxPoint;
            }
        }
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path =new GraphicsPath();
                Diameter = ((End.X - Start.X) + (End.Y - Start.Y)) / 2;
                path.AddEllipse(new Rectangle(Start.X,Start.Y,Diameter,Diameter));
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
            Start = new Point(Start.X+distance.X,Start.Y+distance.Y);
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
            using (Pen pen = new Pen(Color.DarkBlue, 1) { DashStyle = DashStyle.Dash })
            {             
                if (Start.X > End.X&& Start.Y >End.Y)
                {
                    graphics.DrawRectangle(pen,new Rectangle( MinPoint.X - 1, MinPoint.Y - 1,MaxPoint.X-MinPoint.X+2, MaxPoint.Y -MinPoint.Y+ 2));
                }
                else                    
                graphics.DrawRectangle(pen, MinPoint.X-1, MinPoint.Y-1, System.Math.Abs(Diameter)+2, System.Math.Abs(Diameter) + 2);
                //Vẽ điểm max và min để thu phóng hình
                graphics.FillEllipse(Brushes.Blue, MinPoint.X - 3, MinPoint.Y - 3, 7, 7);
                graphics.FillEllipse(Brushes.Blue, MaxPoint.X - 3, MaxPoint.Y - 3, 7, 7);
            }

        }

        public override void ZoomInOut(Point point)
        {
            this.End = new Point(End.X + point.X, End.Y + point.Y);
        }
    }
}
