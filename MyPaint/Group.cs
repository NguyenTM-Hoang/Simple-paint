using System.Windows.Forms;
using System.Drawing;
using System;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
namespace MyPaint
{
    public class Group : Shape
    {
        public List<Shape> ListShape = new List<Shape>();
 
        public void Add (Shape shape)
        {
            this.ListShape.Add(shape);
        }
       
        public override Point MinPoint
        {
            get
            {
                Point minPoint = ListShape[0].MinPoint;
                for (int i=1;i<ListShape.Count;i++)
                {
                    if (ListShape[i].MinPoint.X < minPoint.X) minPoint.X = ListShape[i].MinPoint.X;
                    if (ListShape[i].MinPoint.Y < minPoint.Y) minPoint.Y = ListShape[i].MinPoint.Y;

                }
                return minPoint;
            }
        }

        public override  Point MaxPoint
        {
            get
            {
                Point maxPoint = ListShape[0].MaxPoint;
                for (int i = 1; i < ListShape.Count; i++)
                {
                    if (ListShape[i].MaxPoint.X > maxPoint.X) maxPoint.X = ListShape[i].MaxPoint.X;
                    if (ListShape[i].MaxPoint.Y > maxPoint.Y) maxPoint.Y = ListShape[i].MaxPoint.Y;

                }
                return maxPoint;
            }
        }


        private GraphicsPath[] GraphicsPaths
        {
            get
            {
                GraphicsPath[] graphicsPath = new GraphicsPath[ListShape.Count];
                for (int i=0;i< ListShape.Count;i++)
                {
                    
                    GraphicsPath path = new GraphicsPath();
                    if (ListShape[i] is Line)
                    {
                        path.AddLine(ListShape[i].Start, ListShape[i].End);
                    }
                    else if (ListShape[i] is Circle c)
                    {
                       
                        int Diameter = ((c.End.X - c.Start.X) + (c.End.Y - c.Start.Y)) / 2;
                        path.AddEllipse(new Rectangle(c.Start.X, c.Start.Y, c.Diameter, c.Diameter));
                    }
                    else if (ListShape[i] is Ellipse ellipse)
                    {
                        path.AddEllipse(new Rectangle(ellipse.Start.X, ellipse.Start.Y,ellipse.End.X -ellipse.Start.X, ellipse.End.Y - ellipse.Start.Y));
                    }
                    else if (ListShape[i] is Polygon p)
                    {
                        path.AddPolygon(p.ListPoint.ToArray());
                    }
                    else if (ListShape[i] is Square sq)
                    {
                        path.AddRectangle(new Rectangle(sq.MinPoint.X, sq.MinPoint.Y, System.Math.Abs(sq.MaxPoint.X - sq.MinPoint.X), System.Math.Abs(sq.MaxPoint.X - sq.MinPoint.X)));

                    }
                    else if(ListShape[i] is Rectangl r)
                    {
                        path.AddRectangle(new Rectangle(r.MinPoint.X,r.MinPoint.Y, System.Math.Abs(r.MaxPoint.X - r.MinPoint.X), System.Math.Abs(r.MaxPoint.Y - r.MinPoint.Y)));
                    }
                    else if (ListShape[i] is Curve t)
                    {
                        path.AddCurve(t.ListPoint.ToArray());
                    }
                    else if (ListShape[i] is Bezier b)
                    {
                        path.AddCurve(b.ListPoint.ToArray());
                    }
                    else if (ListShape[i] is Group g)
                    {
                        for (int j = 0; j < g.GraphicsPaths.Length; j++)
                           path.AddPath(g.GraphicsPaths[j], true);
                    }
                    graphicsPath[i]= path;

                }
                return graphicsPath;
            }
        }

        public override void Draw(Graphics graphics)
        {

            GraphicsPath[] paths = GraphicsPaths;
            for (int i = 0; i < paths.Length; i++)
            {
               
                using (GraphicsPath path = paths[i])
                {
                    if (this.ListShape[i] is FillableShape)
                    {
                        if (this.ListShape[i].Fill)
                        {
                            this.ListShape[i].DrawFillBrush(graphics, path, this. ListShape[i].Mybrush);
                        }
                        else
                        {
                            using (Pen mypen = new Pen(ListShape[i].Color, ListShape[i].WidthLine) { DashStyle = ListShape[i].DashStyle })
                            {
                                graphics.DrawPath(mypen, path);
                            }
                            // ListShape[i].Draw(graphics);
                        }
                    }
                    else if (ListShape[i] is Group group)
                    {
                        group.Draw(graphics);
                    }
                    else
                    {
                        using (Pen mypen = new Pen(ListShape[i].Color, ListShape[i].WidthLine) { DashStyle = ListShape[i].DashStyle })
                        {
                            graphics.DrawPath(mypen, path);
                        }
                    }


                }
            }
        }

        public override bool IsOver(Point p)
        {

            GraphicsPath[] paths = GraphicsPaths;
            for (int i = 0; i < GraphicsPaths.Length; i++)
            {
                using (GraphicsPath path = paths[i])
                {
                    if (ListShape[i] is FillableShape)
                    {
                        if (ListShape[i].Fill)
                        {
                            if (paths[i].IsVisible(p)) return true;
                        }
                        else
                        {
                            using (Pen mypen = new Pen(ListShape[i].Color, ListShape[i].WidthLine + 5) { DashStyle = ListShape[i].DashStyle })
                            {
                                if (paths[i].IsOutlineVisible(p, mypen)) return true;
                            }
                            // ListShape[i].Draw(graphics);
                        }
                    }
                    else if (ListShape[i] is Group group)
                    {
                        if (group.IsOver(p)) return true;
                    }
                    else
                    {
                        using (Pen mypen = new Pen(ListShape[i].Color, ListShape[i].WidthLine + 5) { DashStyle = ListShape[i].DashStyle })
                        {
                            if (paths[i].IsOutlineVisible(p, mypen)) return true;
                        }
                    }

                }
            }
            return false;
        }

        public override void Move(Point distance)
        {
            for(int i=0;i<this.ListShape.Count;i++)
            {
                ListShape[i].Move(distance);
            }
        }

        public override void DrawFrame(Graphics graphics)
        {
            //vẽ khung cho shape
            using (Pen pen = new Pen(Brushes.DarkBlue, 1) { DashStyle = DashStyle.Dash })
            {
                graphics.DrawRectangle(pen, this.MinPoint.X, this.MinPoint.Y, this.MaxPoint.X - this.MinPoint.X, this.MaxPoint.Y - this.MinPoint.Y);
            }
            //Vẽ điểm max và min để thu phóng hình
            graphics.FillEllipse(Brushes.Blue, MinPoint.X - 3, MinPoint.Y - 3, 7, 7);
            graphics.FillEllipse(Brushes.Blue, MaxPoint.X - 3, MaxPoint.Y - 3, 7, 7);
        }

        public override void ZoomInOut(Point p)
        {
            // Point t = new Point(p.X - MaxPoint.X, p.Y - MaxPoint.Y);
            for (int i = 0; i < this.ListShape.Count; i++)
            {
              
                ListShape[i].ZoomInOut(p);

            }
        }
        protected override GraphicsPath GraphicsPath => null;
    }
}
