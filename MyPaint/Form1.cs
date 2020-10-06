using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace MyPaint
{
    public enum Currentshape
    {
        Circle,
        Line,
        Square,
        Rectangle,
        Polygon,
        Bezier,
        Curve,
        Ellipse,
        Pen,
        Text,
        Nodrawing
    }


    public partial class Form1 : Form
    {
       // private List<Button> btnColors;
       // private List<Button> btnShapes;
        private List<Shape> shapes = new List<Shape>();
       
        private Currentshape currentshape;
       
        private Point movepoint;

        private Point zoompoint;
        private bool usingPen = false;
        private bool ChooseOutlineColor = true;
        private bool ChooseBackColor = false;
        private bool isSelected=false;
        private bool isCTRLpress = false;
        private bool isCurve;
        private bool isPolygon;
        private bool isMouseDown = false;
        private bool isBezier;
        private bool isMoving = false;
        private bool isZominout = false;
        private bool drawregion = false;
        private bool isdrawregion = false;
        private Rectangl region;
        public Form1()
        {

            InitializeComponent();
 
            // Create rectangle for drawing.
            
            cmbFillMode.SelectedIndex = 3;
            cmbOutline.SelectedIndex = 0;
            BackCo.BackColor = fillCoBut.BackColor = Color.Transparent;
            outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            cmbLinear.SelectedIndex = 0;
            this.Focus();
            
            
        }

        #region Color Buttoon
        private void ChooseCo_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.FullOpen = true;
            if (color.ShowDialog() == DialogResult.OK)
            {
                if (ChooseBackColor)
                {
                    BackCo.BackColor = color.Color;
                    label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                    outLineBut.BackColor = label2.BackColor = Color.Transparent;
                }
                else
                {
                    Outlineco.BackColor = color.Color;
                    label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                    outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
                }

            }
        }

        private void Black_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Black;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Black;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void Outlineco_Click(object sender, EventArgs e)
        {
            label3.BackColor = fillCoBut.BackColor = Color.Transparent;
            outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            ChooseOutlineColor = true;
            ChooseBackColor = false;
        }

        private void BackCo_Click(object sender, EventArgs e)
        {
            label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
            outLineBut.BackColor = label2.BackColor = Color.Transparent;
            ChooseBackColor = true;
            ChooseOutlineColor = false;
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Gray;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Gray;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void DarkRed_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.DarkRed;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.DarkRed;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Orange;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Orange;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Yellow;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Yellow;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void Green_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Green;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Green;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void Cyan_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Cyan;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Cyan;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Blue;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Blue;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Purple;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Purple;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void White_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.White;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.White;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void LightGray_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.LightGray;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.LightGray;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void LightCoral_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.LightCoral;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.LightCoral;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void Gold_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Gold;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Gold;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void LightYellow_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.LightYellow;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.LightYellow;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void YellowGreen_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.YellowGreen;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.YellowGreen;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void LigthBlue_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.LightBlue;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.LightBlue;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void Teal_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.Teal;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.Teal;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }

        private void DarkKhaki_Click(object sender, EventArgs e)
        {
            if (ChooseBackColor)
            {
                BackCo.BackColor = Color.DarkKhaki;
                label3.BackColor = fillCoBut.BackColor = Color.PaleTurquoise;
                outLineBut.BackColor = label2.BackColor = Color.Transparent;
            }
            else
            {
                Outlineco.BackColor = Color.DarkKhaki;
                label3.BackColor = fillCoBut.BackColor = Color.Transparent;
                outLineBut.BackColor = label2.BackColor = Color.PaleTurquoise;
            }
        }
        #endregion

        #region Choose Shape Button
        private void BtnLine_Click(object sender, EventArgs e)
        {
            currentshape = Currentshape.Line;
            cmbFillMode.Enabled = false;
            plMain.Cursor = Cursors.Cross;
            isSelected = false;
            foreach (Shape s in shapes)
                s.IsSelected = false;
            plMain.Invalidate();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            currentshape = Currentshape.Rectangle;
            cmbFillMode.Enabled = true;
            plMain.Cursor = Cursors.Cross;
            isSelected = false;
            foreach (Shape s in shapes)
                s.IsSelected = false;
            plMain.Invalidate();

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            currentshape = Currentshape.Square;
            cmbFillMode.Enabled = true;
            plMain.Cursor = Cursors.Cross;
            isSelected = false;
            foreach (Shape s in shapes)
                s.IsSelected = false;
            plMain.Invalidate();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentshape = Currentshape.Circle;
            cmbFillMode.Enabled = true;
            plMain.Cursor = Cursors.Cross;
            isSelected = false;
            foreach (Shape s in shapes)
                s.IsSelected = false;
            plMain.Invalidate();
        }

        private void btnCurve_Click(object sender, EventArgs e)
        {
            currentshape = Currentshape.Curve;
            cmbFillMode.Enabled = false;
            plMain.Cursor = Cursors.Cross;
            isSelected = false;
        }

        private void btnPol_Click(object sender, EventArgs e)
        {
            currentshape = Currentshape.Polygon;
            cmbFillMode.Enabled = true;
            plMain.Cursor = Cursors.Cross;
            isSelected = false;
            foreach (Shape s in shapes)
                s.IsSelected = false;
            plMain.Invalidate();
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            currentshape = Currentshape.Bezier;
            cmbFillMode.Enabled = false;
            plMain.Cursor = Cursors.Cross;
            isSelected = false;
            foreach (Shape s in shapes)
                s.IsSelected = false;
            plMain.Invalidate();
        }

        private void btnElip_Click(object sender, EventArgs e)
        {
            currentshape = Currentshape.Ellipse;
            cmbFillMode.Enabled = true;
            plMain.Cursor = Cursors.Cross;
            isSelected = false;
            foreach (Shape s in shapes)
                s.IsSelected = false;
            plMain.Invalidate();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            currentshape = Currentshape.Nodrawing;
            isSelected = true;
            cmbFillMode.Enabled = true;
            isMouseDown = false;
            isPolygon = false;
            isCurve = false;
            isBezier = false;
            foreach (Shape s in shapes)
                s.IsSelected = false;
            plMain.Invalidate();
            // plMain.Cursor = Cursors.SizeAll;
        }
       
        

        private void btngroup_Click(object sender, EventArgs e)
        {
            //  foreach(Shape shape in shapes) 
            if (shapes.Count(shape => shape.IsSelected) > 1)
            {
                //MessageBox.Show("Group");
                Group group = new Group();
                for(int i=0;i<shapes.Count;i++)
                {
                    if (shapes[i].IsSelected)
                    {
                        shapes[i].IsSelected = false;                      
                        group.Add(shapes[i]);
                        shapes.RemoveAt(i);
                        i = i - 1;
                    }
                }
                group.IsSelected = true;
                shapes.Add(group);
                plMain.Refresh();

            }
            else foreach (Shape shape in shapes)
            {
                 shape.IsSelected = false;
                 plMain.Invalidate();
            }

        }
        private void btnungroup_Click(object sender, EventArgs e)
        {
            int T = shapes.Count;
            for(int j=0;j< T;j++)
            {
                if(shapes[j].IsSelected && shapes[j] is Group a)
                {
                    for (int i = 0; i < a.ListShape.Count; i++)
                    {
                        a.ListShape[i].IsSelected = true;
                        shapes.Add(a.ListShape[i]);

                    }
                    shapes.RemoveAt(j);
                    T--;
                    j--;
                }
            }

            plMain.Invalidate();
        }
        private void btnPen_Click(object sender, EventArgs e)
        {
            currentshape = Currentshape.Pen;
            plMain.Cursor = Cursors.Hand;
            isSelected = false;
            foreach (Shape s in shapes)
                s.IsSelected = false;
            plMain.Invalidate();
        }

        #endregion

        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
                      
            if (isSelected)
            {
                bool nohit = true;
                if (isCTRLpress)
                {                   
                    foreach (Shape shape in shapes)
                    {
                        if (shape.IsOver(e.Location))
                        {
                            shape.IsSelected = !shape.IsSelected;
                            nohit = false;
                            plMain.Invalidate();
                        }
                    }

                    if(nohit) foreach(Shape shape in shapes)
                    {
                            shape.IsSelected = false;
                    }
                }
                else
                {
                    if(plMain.Cursor!=Cursors.SizeNWSE)
                    foreach (Shape shape in shapes)
                    {                        
                        if (shape.IsOver(e.Location))
                        {                                
                            shape.IsSelected =true;
                            nohit = false;
                        }
                        else
                        {
                            shape.IsSelected = false;
                            
                        }
                        
                        plMain.Invalidate();
                    }
                    else
                    {
                        
                        isZominout = true;
                        zoompoint = e.Location;
                    }
                }
                if(nohit==false)
                {
                    isMoving = true;
                    movepoint = e.Location;
                }
                else
                {
                    drawregion = true;
                    isdrawregion = false;
                    region = new Rectangl();
                    region.Color = Color.Black;
                    region.WidthLine = 1;
                    region.DashStyle = DashStyle.Dash;
                    region.Start = e.Location;
                }
                isMouseDown = false;              
                plMain.Invalidate();
            }

            
            //Pen
            if (currentshape==Currentshape.Pen)
            {
                usingPen = true;
                Pencil pencil = new Pencil();
                pencil.listPoint.Add(e.Location);
                pencil.listPoint.Add(e.Location);
                pencil.Color = Outlineco.BackColor;
                pencil.WidthLine = trackLinewidth.Value;
                shapes.Add(pencil);
                isMouseDown = true;
            }
            
            //Line
            if (currentshape == Currentshape.Line)
            {
                Line line = new Line();
                line.Start = e.Location;
                line.Color = Outlineco.BackColor;
                line.DashStyle = (DashStyle)cmbOutline.SelectedIndex;
                line.WidthLine = trackLinewidth.Value;
                shapes.Add(line);
                isMouseDown = true;
            }
            //Hinh tron
            if (currentshape == Currentshape.Circle)
            {
                Circle circle = new Circle();
                circle.Start = e.Location;

                circle.DashStyle = (DashStyle)cmbOutline.SelectedIndex;
                circle.WidthLine = trackLinewidth.Value;

                if (cmbFillMode.SelectedItem.ToString() == "NoFill")
                {
                    circle.Fill = false;
                    circle.Color = Outlineco.BackColor;
                }
                else if (cmbFillMode.SelectedItem.ToString() == "Solid")
                {

                    circle.Fill = true;
                    circle.Mybrush = "Solid";
                    circle.Color = Outlineco.BackColor;
                    circle.ColorFill = BackCo.BackColor;
                }
                else if (cmbFillMode.SelectedItem.ToString() == "HatchBrush" )
                {
                    circle.Fill = true;
                    circle.Mybrush = cmbHatchBrush.SelectedItem.ToString();
                    circle.Color1 = btnCl1Hatch.BackColor;
                    circle.Color2 = btnCl2Hatch.BackColor;

                }
                else if ( cmbFillMode.SelectedItem.ToString() == "LinearGradient")
                {
                    circle.Fill = true;
                    circle.Mybrush = cmbLinear.SelectedItem.ToString() + "Linear";
                    circle.Color1 = btnCl1Hatch.BackColor;
                    circle.Color2 = btnCl2Hatch.BackColor;

                }
               
                shapes.Add(circle);
                isMouseDown = true;

            }
            // Hinh Elip
            if (currentshape == Currentshape.Ellipse)
            {
                Ellipse elip = new Ellipse();
                elip.Start = e.Location;

                elip.DashStyle = (DashStyle)cmbOutline.SelectedIndex;
                elip.WidthLine = trackLinewidth.Value;

                if (cmbFillMode.SelectedItem.ToString() == "NoFill")
                {
                    elip.Fill = false;
                    elip.Color = Outlineco.BackColor;
                }
                else if (cmbFillMode.SelectedItem.ToString() == "Solid")
                {

                    elip.Fill = true;
                    elip.Mybrush = "Solid";
                    elip.Color = Outlineco.BackColor;
                    elip.ColorFill = BackCo.BackColor;
                }
                else if (cmbFillMode.SelectedItem.ToString() == "HatchBrush")
                {
                    elip.Fill = true;
                    elip.Mybrush = cmbHatchBrush.SelectedItem.ToString();
                    elip.Color1 = btnCl1Hatch.BackColor;
                    elip.Color2 = btnCl2Hatch.BackColor;

                }
                else if (cmbFillMode.SelectedItem.ToString() == "LinearGradient")
                {
                    elip.Fill = true;
                    elip.Mybrush = cmbLinear.SelectedItem.ToString() + "Linear";
                    elip.Color1 = btnCl1Hatch.BackColor;
                    elip.Color2 = btnCl2Hatch.BackColor;

                }
                
                shapes.Add(elip);
                isMouseDown = true;
            }
            //Hinh vuong
            if (currentshape == Currentshape.Square)
            {
                Square s = new Square();
                s.Start = e.Location;

                s.DashStyle = (DashStyle)cmbOutline.SelectedIndex;
                s.WidthLine = trackLinewidth.Value;

                if (cmbFillMode.SelectedItem.ToString() == "NoFill")
                {
                    s.Fill = false;
                    s.Color = Outlineco.BackColor;
                }
                else if (cmbFillMode.SelectedItem.ToString() == "Solid")
                {

                    s.Fill = true;
                    s.Mybrush = "Solid";
                    s.Color = Outlineco.BackColor;
                    s.ColorFill = BackCo.BackColor;
                }
                else if (cmbFillMode.SelectedItem.ToString() == "HatchBrush")
                {
                    s.Fill = true;
                    s.Mybrush = cmbHatchBrush.SelectedItem.ToString();
                    s.Color1 = btnCl1Hatch.BackColor;
                    s.Color2 = btnCl2Hatch.BackColor;

                }
                else if (cmbFillMode.SelectedItem.ToString() == "LinearGradient")
                {
                    s.Fill = true;
                    s.Mybrush = cmbLinear.SelectedItem.ToString() + "Linear";
                    s.Color1 = btnCl1Hatch.BackColor;
                    s.Color2 = btnCl2Hatch.BackColor;

                }

                shapes.Add(s);
                isMouseDown = true;
            }
            //Hinh chu nhat
            if (currentshape == Currentshape.Rectangle)
            {
                Rectangl s = new Rectangl();
                s.Start = e.Location;
                s.DashStyle = (DashStyle)cmbOutline.SelectedIndex;
                s.WidthLine = trackLinewidth.Value;

                if (cmbFillMode.SelectedItem.ToString() == "NoFill")
                {
                    s.Fill = false;
                    s.Color = Outlineco.BackColor;
                }
                else if (cmbFillMode.SelectedItem.ToString() == "Solid")
                {

                    s.Fill = true;
                    s.Mybrush = "Solid";
                    s.Color = Outlineco.BackColor;
                    s.ColorFill = BackCo.BackColor;
                }
                else if (cmbFillMode.SelectedItem.ToString() == "HatchBrush")
                {
                    s.Fill = true;
                    s.Mybrush = cmbHatchBrush.SelectedItem.ToString();
                    s.Color1 = btnCl1Hatch.BackColor;
                    s.Color2 = btnCl2Hatch.BackColor;

                }
                else if (cmbFillMode.SelectedItem.ToString() == "LinearGradient")
                {
                    s.Fill = true;
                    s.Mybrush = cmbLinear.SelectedItem.ToString() + "Linear";
                    s.Color1 = btnCl1Hatch.BackColor;
                    s.Color2 = btnCl2Hatch.BackColor;

                }
               
                shapes.Add(s);
                isMouseDown = true;
            }
            //Hinh Polygon
            if (currentshape == Currentshape.Polygon)
            {
                if(!isPolygon)
                {
                    Polygon s = new Polygon();
                    s.Start = e.Location;
                    s.ListPoint.Add(e.Location);
                    s.ListPoint.Add(e.Location);
                    s.DashStyle = (DashStyle)cmbOutline.SelectedIndex;
                    s.WidthLine = trackLinewidth.Value;

                    if (cmbFillMode.SelectedItem.ToString() == "NoFill")
                    {
                        s.Fill = false;
                        s.Color = Outlineco.BackColor;
                    }
                    else if (cmbFillMode.SelectedItem.ToString() == "Solid")
                    {

                        s.Fill = true;
                        s.Mybrush = "Solid";
                        s.Color = Outlineco.BackColor;
                        s.ColorFill = BackCo.BackColor;
                    }
                    else if (cmbFillMode.SelectedItem.ToString() == "HatchBrush")
                    {
                        s.Fill = true;
                        s.Mybrush = cmbHatchBrush.SelectedItem.ToString();
                        s.Color1 = btnCl1Hatch.BackColor;
                        s.Color2 = btnCl2Hatch.BackColor;

                    }
                    else if (cmbFillMode.SelectedItem.ToString() == "LinearGradient")
                    {
                        s.Fill = true;
                        s.Mybrush = cmbLinear.SelectedItem.ToString() + "Linear";
                        s.Color1 = btnCl1Hatch.BackColor;
                        s.Color2 = btnCl2Hatch.BackColor;

                    }
                    
                    shapes.Add(s);
                    isPolygon = true;
                }
                else
                {
                    Polygon p = shapes[shapes.Count - 1] as Polygon;
                    p.ListPoint[p.ListPoint.Count - 1] = e.Location;
                    p.ListPoint.Add(e.Location);
                }
                isMouseDown = false;
            }
            //Hinh Curve
            if (currentshape == Currentshape.Curve)
            {
                if (!isCurve)
                {
                    Curve s = new Curve();
                    s.ListPoint.Add(e.Location);
                    s.ListPoint.Add(e.Location);
                    s.DashStyle = (DashStyle)cmbOutline.SelectedIndex;
                    s.WidthLine = trackLinewidth.Value;
                    s.Color = Outlineco.BackColor;                   
                    shapes.Add(s);
                    isCurve = true;
                }
                else
                {
                    Curve p = shapes[shapes.Count - 1] as Curve;
                    p.ListPoint[p.ListPoint.Count - 1] = e.Location;
                    p.ListPoint.Add(e.Location);
                }
                isMouseDown = false;
            }
            //Hinh Bezier
            if (currentshape == Currentshape.Bezier)
            {
                if (!isBezier)
                {
                   Bezier s = new Bezier();
                    s.ListPoint.Add(e.Location);
                    s.ListPoint.Add(e.Location);
                    s.DashStyle = (DashStyle)cmbOutline.SelectedIndex;
                    s.WidthLine = trackLinewidth.Value;
                    s.Color = Outlineco.BackColor;
                    shapes.Add(s);
                    isBezier = true;
                }
                else
                {
                    Bezier p = shapes[shapes.Count - 1] as Bezier;
                    if (p.ListPoint.Count <=4)
                    {
                        p.ListPoint[p.ListPoint.Count - 1] = e.Location;
                        p.ListPoint.Add(e.Location);
                    }
                    if (p.ListPoint.Count == 5)
                    {
                        p.ListPoint.RemoveAt(4);
                        isBezier = false;
                        plMain.Invalidate();
                    
                    }
                   
                }
                isMouseDown = false;
            }

        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (Shape shape in shapes)
            {                
                shape.Draw(e.Graphics);    
                if(shape.IsSelected)
                {
                    shape.DrawFrame(e.Graphics);
                }                
            }
            if (isdrawregion)
                region.Draw(e.Graphics);

        }

        private void btnCl1Hatch_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = true;
            if (color.ShowDialog() == DialogResult.OK)
                btnCl1Hatch.BackColor = color.Color;
        }

        private void btnCl2Hatch_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = true;
            if (color.ShowDialog() == DialogResult.OK)
                btnCl2Hatch.BackColor = color.Color;
        }

        private void trackLinewidth_Scroll(object sender, EventArgs e)
        {


            if (trackLinewidth.Value == 0) lbWidth.Text = "Default";
            else lbWidth.Text = trackLinewidth.Value.ToString();

            foreach (Shape shape in shapes)
                if (shape.IsSelected)
                {
                    if (shape is Group g)
                    {
                        foreach(Shape s in g.ListShape)
                        {
                            s.WidthLine = trackLinewidth.Value;
                        }
                    }
                    else
                        shape.WidthLine = trackLinewidth.Value;
                }
            plMain.Invalidate();
        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isZominout)
            {              
                isdrawregion = false;
                foreach (Shape shape in shapes)
                {
                    if (shape.IsSelected)
                    {
                        Point p = new Point(e.Location.X - zoompoint.X, e.Location.Y - zoompoint.Y);           
                        shape.ZoomInOut(p);                      
                    }
                }
                zoompoint = e.Location;
                plMain.Invalidate();
            }
            else
            if (isSelected)
            {
                if (isMoving == false)
                {
                    bool noHit = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape.IsSelected)
                        {
                            GraphicsPath graphicsPathmin = new GraphicsPath();
                            graphicsPathmin.AddEllipse(new Rectangle(shape.MinPoint.X - 3, shape.MinPoint.Y - 3, 7, 7));
                            GraphicsPath graphicsPathmax = new GraphicsPath();
                            graphicsPathmax.AddEllipse(new Rectangle(shape.MaxPoint.X - 3, shape.MaxPoint.Y - 3, 7, 7));
                            bool t = graphicsPathmin.IsVisible(e.Location);
                            bool k = graphicsPathmax.IsVisible(e.Location);
                            if (k)
                            { 
                             
                                plMain.Cursor = Cursors.SizeNWSE;
                                noHit = false;

                            }
                            else if (shape.IsOver(e.Location))
                            {
                                plMain.Cursor = Cursors.SizeAll;
                                noHit = false;
                            }
                        }
                        else
                        if (shape.IsOver(e.Location))
                        {
                            plMain.Cursor = Cursors.SizeAll;
                            noHit = false;
                        }                      
                    }
                    if (noHit)
                    {
                        plMain.Cursor = Cursors.Default;
                        if (drawregion)
                        {
                            isdrawregion = true;
                            region.End = e.Location;
                            plMain.Invalidate();
                        }
                    }
                }
                else
                {
                    foreach (Shape shape in shapes)
                    {
                        if (shape.IsSelected)
                        {
                            shape.Move(new Point(e.Location.X - movepoint.X, e.Location.Y - movepoint.Y));                           
                        }
                       
                    }
                    movepoint = e.Location;
                    plMain.Invalidate();
                }

            }
            if (isMouseDown)
            {
                if(usingPen)
                {
                    Pencil pencil = shapes[shapes.Count - 1] as Pencil;
                    pencil.listPoint.Add(e.Location);
                }
                else
                shapes[shapes.Count - 1].End = e.Location;
                plMain.Invalidate();
            }

            if (isPolygon)
            {
                Polygon p = shapes[shapes.Count - 1] as Polygon;
                p.ListPoint[p.ListPoint.Count - 1] = e.Location;
                shapes[shapes.Count - 1].End = e.Location;
                plMain.Invalidate();
            }
            if (isCurve)
            {
                Curve curve = shapes[shapes.Count - 1] as Curve;
                curve.ListPoint[curve.ListPoint.Count - 1] = e.Location;
                plMain.Invalidate();
            }
            if (isBezier)
            {
                Bezier bezier = shapes[shapes.Count - 1] as Bezier;
                bezier.ListPoint[bezier.ListPoint.Count - 1] = e.Location;
                plMain.Invalidate();

            }
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            if(isMoving)
            {
                isMoving = false;
            }
            if(isZominout)
            {
                isZominout = false;
            }
            if(currentshape!=Currentshape.Nodrawing)
            {
                if (usingPen)
                    usingPen = false;
                if(currentshape!=Currentshape.Polygon && currentshape!=Currentshape.Curve&& currentshape!=Currentshape.Bezier )              
                shapes[shapes.Count - 1].End = e.Location;
                plMain.Invalidate();
            } 
            if(drawregion)
            {
                drawregion = false;
                isdrawregion = false;
                region.End = e.Location;
                foreach (Shape shape in shapes)
                {
                    if (shape.MinPoint.X > region.MinPoint.X && shape.MinPoint.Y > region.MinPoint.Y && shape.MaxPoint.X < region.MaxPoint.X && shape.MaxPoint.Y < region.MaxPoint.Y)
                        shape.IsSelected = true;

                }
                plMain.Invalidate();
            }
            isMouseDown = false;
        }

        private void cmbFillMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFillMode.SelectedItem.ToString() == "HatchBrush")
            {
                plHatchBrush.Visible = true;
                lbBrush.Text = "Hatch Brush Style";
                cmbHatchBrush.Visible = true;
                cmbHatchBrush.SelectedIndex = 0;
                cmbLinear.Visible = false;
            }
            else 
                if (cmbFillMode.SelectedItem.ToString() == "LinearGradient")
                {
                    lbBrush.Text = "Linear Gradient";
                    plHatchBrush.Visible = true;
                    cmbHatchBrush.Visible = false;
                    cmbLinear.Visible = true;
                     p.Enabled = true;
                }
            else              
                plHatchBrush.Visible = false;
           
        }
        
        private void cmbHatchBrush_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentshape != Currentshape.Nodrawing)
                p.Enabled = true;
            else p.Enabled = false;
        }

        private void plMain_DoubleClick(object sender, EventArgs e)
        {
            if(isPolygon)
            {
                isPolygon = false;
                Polygon p = shapes[shapes.Count - 1] as Polygon;
                p.ListPoint.RemoveAt(p.ListPoint.Count - 1);
                p.ListPoint.RemoveAt(p.ListPoint.Count - 1);
                //shapes[shapes.Count - 1].End = p.ListPoint[p.ListPoint.Count - 1];
                plMain.Invalidate();
            }
            if(isCurve)
            {
                isCurve = false;
                Curve c = shapes[shapes.Count - 1] as Curve;
                c.ListPoint.RemoveAt(c.ListPoint.Count - 1);
                c.ListPoint.RemoveAt(c.ListPoint.Count - 1);
                plMain.Invalidate();
            }
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.ControlKey)
            {
                isCTRLpress = true;
               
            }
            if (e.KeyCode==Keys.Delete)
            {
                for(int i=0;i<shapes.Count;i++ )
                {
                    if (shapes[i].IsSelected)
                    {
                        shapes.RemoveAt(i);
                        i--;
                    }
                }
               
                plMain.Invalidate();
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.ControlKey)
            {
                isCTRLpress = false;
               
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plMain.Focus();
        }

        

        private void Outlineco_BackColorChanged(object sender, EventArgs e)
        {
            foreach (Shape shape in shapes)
                if (shape.IsSelected)
                {
                    if(shape is Group g)
                        foreach( Shape s in g.ListShape)
                        {
                            if (!s.Fill) s.Color = Outlineco.BackColor;
                        }
                    else
                        if (!shape.Fill) shape.Color = Outlineco.BackColor;
                }
            plMain.Invalidate();
            
        }

        private void BackCo_BackColorChanged(object sender, EventArgs e)
        {
            foreach (Shape shape in shapes)
                if (shape.IsSelected)
                {
                    if (shape is Group g)
                        foreach (Shape s in g.ListShape)
                        {
                            if (s is FillableShape a )
                            {
                                a.Fill = true;
                                a.Mybrush = "Solid";
                                a.ColorFill = BackCo.BackColor;
                            }
                        }
                    else
                    if (shape is FillableShape a )
                    {
                        a.Fill = true;
                        a.Mybrush = "Solid";
                        a.ColorFill = BackCo.BackColor;
            
                    }
                }
            plMain.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsSelected)
                {
                    shapes.RemoveAt(i);
                    i--;
                }
            }

            plMain.Invalidate();
        }

        private void cmbOutline_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                if(shape.IsSelected)
                    if(!shape.Fill)
                        shape.DashStyle = (DashStyle)cmbOutline.SelectedIndex;

            }
            plMain.Invalidate();
        }
    }
}
