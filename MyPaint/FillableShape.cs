using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace MyPaint
{
    public abstract class FillableShape:Shape
    {
        public Color ColorFill;
        public Color Color1;
        public Color Color2;
       

        public override void  DrawFillBrush(Graphics graphics, GraphicsPath path, string mybrush)
        {
            if (mybrush == "Solid")
            {
                using (SolidBrush brush = new SolidBrush(ColorFill))
                {
                    graphics.FillPath(brush, path);
                }
               
            }
            if (mybrush == "BackwardDiagonal")
            {
                using (HatchBrush hatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color1,Color2))
                {
                    graphics.FillPath(hatchBrush, path);
                  
                }
              
            }
            if (mybrush == "DiagonalCross")
            {
                using (HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color1, Color2))
                {
                    graphics.FillPath(hatchBrush, path);
                }
            }
            if(mybrush== "HorizontalBrick")
            {
                using (HatchBrush hatchBrush = new HatchBrush(HatchStyle.HorizontalBrick, Color1, Color2))
                {
                    graphics.FillPath(hatchBrush, path);
                }
            }
            if (mybrush == "LightDownwardDiagonal")
            {
                using (HatchBrush hatchBrush = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color1, Color2))
                {
                    graphics.FillPath(hatchBrush, path);
                }
            }
            if(mybrush== "BackwardDiagonalLinear")
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(Start.X, Start.Y, System.Math.Abs(End.X-Start.X)+2, System.Math.Abs(End.Y - Start.Y)+2), Color1, Color2, LinearGradientMode.BackwardDiagonal))
                {
                    graphics.FillPath(brush, path);
                }
            }
            if (mybrush == "ForwardDiagonalLinear")
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(Start.X, Start.Y, System.Math.Abs(End.X - Start.X) + 2, System.Math.Abs(End.Y - Start.Y) + 2), Color1, Color2, LinearGradientMode.ForwardDiagonal))
                {
                    graphics.FillPath(brush, path);
                }
            }

            if (mybrush == "HorizontalLinear")
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(Start.X, Start.Y, System.Math.Abs(End.X - Start.X) + 2, System.Math.Abs(End.Y - Start.Y) + 2), Color1, Color2, LinearGradientMode.Horizontal))
                {
                    graphics.FillPath(brush, path);
                }
            }

            if (mybrush == "VerticalLinear")
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(Start.X, Start.Y, System.Math.Abs(End.X - Start.X) + 5, System.Math.Abs(End.Y - Start.Y)+5 ), Color1, Color2, LinearGradientMode.Vertical))
                {
                    graphics.FillPath(brush, path);
                }
            }
            

        }

    }
}
