namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnungroup = new System.Windows.Forms.Button();
            this.btngroup = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.trackLinewidth = new System.Windows.Forms.TrackBar();
            this.btnPen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnPol = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnElip = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFillMode = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChooseCo = new System.Windows.Forms.Button();
            this.DarkKhaki = new System.Windows.Forms.Button();
            this.Teal = new System.Windows.Forms.Button();
            this.LigthBlue = new System.Windows.Forms.Button();
            this.YellowGreen = new System.Windows.Forms.Button();
            this.LightYellow = new System.Windows.Forms.Button();
            this.Gold = new System.Windows.Forms.Button();
            this.LightCoral = new System.Windows.Forms.Button();
            this.LightGray = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Purple = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Cyan = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.DarkRed = new System.Windows.Forms.Button();
            this.Gray = new System.Windows.Forms.Button();
            this.Outlineco = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.BackCo = new System.Windows.Forms.Button();
            this.outLineBut = new System.Windows.Forms.Button();
            this.fillCoBut = new System.Windows.Forms.Button();
            this.cmbOutline = new System.Windows.Forms.ComboBox();
            this.plHatchBrush = new System.Windows.Forms.Panel();
            this.cmbLinear = new System.Windows.Forms.ComboBox();
            this.p = new System.Windows.Forms.Panel();
            this.btnCl2Hatch = new System.Windows.Forms.Button();
            this.btnCl1Hatch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbHatchBrush = new System.Windows.Forms.ComboBox();
            this.lbBrush = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.plMain = new DoubleBufferPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackLinewidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plHatchBrush.SuspendLayout();
            this.p.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnungroup);
            this.panel1.Controls.Add(this.btngroup);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Controls.Add(this.lbWidth);
            this.panel1.Controls.Add(this.trackLinewidth);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbFillMode);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmbOutline);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnungroup
            // 
            this.btnungroup.BackColor = System.Drawing.Color.Transparent;
            this.btnungroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnungroup.FlatAppearance.BorderSize = 0;
            this.btnungroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnungroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnungroup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnungroup.Location = new System.Drawing.Point(9, 38);
            this.btnungroup.Name = "btnungroup";
            this.btnungroup.Size = new System.Drawing.Size(81, 32);
            this.btnungroup.TabIndex = 17;
            this.btnungroup.Text = "Ungroup";
            this.btnungroup.UseVisualStyleBackColor = false;
            this.btnungroup.Click += new System.EventHandler(this.btnungroup_Click);
            // 
            // btngroup
            // 
            this.btngroup.BackColor = System.Drawing.Color.Transparent;
            this.btngroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngroup.FlatAppearance.BorderSize = 0;
            this.btngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngroup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btngroup.Location = new System.Drawing.Point(9, 8);
            this.btngroup.Name = "btngroup";
            this.btngroup.Size = new System.Drawing.Size(72, 34);
            this.btngroup.TabIndex = 12;
            this.btngroup.Text = "Group";
            this.btngroup.UseVisualStyleBackColor = false;
            this.btngroup.Click += new System.EventHandler(this.btngroup_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb.Location = new System.Drawing.Point(1067, 6);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(57, 13);
            this.lb.TabIndex = 16;
            this.lb.Text = "Line Width";
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWidth.Location = new System.Drawing.Point(1187, 26);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(42, 13);
            this.lbWidth.TabIndex = 15;
            this.lbWidth.Text = "Default";
            // 
            // trackLinewidth
            // 
            this.trackLinewidth.LargeChange = 1;
            this.trackLinewidth.Location = new System.Drawing.Point(1075, 22);
            this.trackLinewidth.Maximum = 6;
            this.trackLinewidth.Name = "trackLinewidth";
            this.trackLinewidth.Size = new System.Drawing.Size(113, 45);
            this.trackLinewidth.TabIndex = 14;
            this.trackLinewidth.Scroll += new System.EventHandler(this.trackLinewidth_Scroll);
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.Transparent;
            this.btnPen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPen.BackgroundImage")));
            this.btnPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPen.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPen.FlatAppearance.BorderSize = 0;
            this.btnPen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPen.Location = new System.Drawing.Point(264, 45);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(35, 21);
            this.btnPen.TabIndex = 12;
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.btnBezier);
            this.groupBox1.Controls.Add(this.btnPol);
            this.groupBox1.Controls.Add(this.btnCurve);
            this.groupBox1.Controls.Add(this.btnElip);
            this.groupBox1.Controls.Add(this.btnPen);
            this.groupBox1.Controls.Add(this.btnCircle);
            this.groupBox1.Controls.Add(this.btnSquare);
            this.groupBox1.Controls.Add(this.btnRect);
            this.groupBox1.Controls.Add(this.BtnLine);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(150, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(264, 19);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(35, 24);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.Transparent;
            this.btnBezier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBezier.BackgroundImage")));
            this.btnBezier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBezier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBezier.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBezier.FlatAppearance.BorderSize = 0;
            this.btnBezier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBezier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBezier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBezier.Location = new System.Drawing.Point(132, 44);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(58, 23);
            this.btnBezier.TabIndex = 10;
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // btnPol
            // 
            this.btnPol.BackColor = System.Drawing.Color.Transparent;
            this.btnPol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPol.BackgroundImage")));
            this.btnPol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPol.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPol.FlatAppearance.BorderSize = 0;
            this.btnPol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPol.Location = new System.Drawing.Point(65, 44);
            this.btnPol.Name = "btnPol";
            this.btnPol.Size = new System.Drawing.Size(66, 23);
            this.btnPol.TabIndex = 9;
            this.btnPol.UseVisualStyleBackColor = false;
            this.btnPol.Click += new System.EventHandler(this.btnPol_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.BackColor = System.Drawing.Color.Transparent;
            this.btnCurve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCurve.BackgroundImage")));
            this.btnCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurve.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCurve.FlatAppearance.BorderSize = 0;
            this.btnCurve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCurve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurve.Location = new System.Drawing.Point(6, 44);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(53, 23);
            this.btnCurve.TabIndex = 8;
            this.btnCurve.UseVisualStyleBackColor = false;
            this.btnCurve.Click += new System.EventHandler(this.btnCurve_Click);
            // 
            // btnElip
            // 
            this.btnElip.BackColor = System.Drawing.Color.Transparent;
            this.btnElip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnElip.BackgroundImage")));
            this.btnElip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElip.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnElip.FlatAppearance.BorderSize = 0;
            this.btnElip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnElip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnElip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElip.Location = new System.Drawing.Point(192, 44);
            this.btnElip.Name = "btnElip";
            this.btnElip.Size = new System.Drawing.Size(48, 23);
            this.btnElip.TabIndex = 7;
            this.btnElip.UseVisualStyleBackColor = false;
            this.btnElip.Click += new System.EventHandler(this.btnElip_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCircle.BackgroundImage")));
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCircle.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCircle.FlatAppearance.BorderSize = 0;
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Location = new System.Drawing.Point(197, 20);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(43, 23);
            this.btnCircle.TabIndex = 6;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Transparent;
            this.btnSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSquare.BackgroundImage")));
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSquare.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Location = new System.Drawing.Point(137, 11);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(49, 31);
            this.btnSquare.TabIndex = 5;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRect
            // 
            this.btnRect.BackColor = System.Drawing.Color.Transparent;
            this.btnRect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRect.BackgroundImage")));
            this.btnRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRect.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRect.FlatAppearance.BorderSize = 0;
            this.btnRect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRect.Location = new System.Drawing.Point(70, 18);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(61, 23);
            this.btnRect.TabIndex = 4;
            this.btnRect.UseVisualStyleBackColor = false;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.BackColor = System.Drawing.Color.Transparent;
            this.BtnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLine.BackgroundImage")));
            this.BtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLine.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnLine.FlatAppearance.BorderSize = 0;
            this.BtnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.Location = new System.Drawing.Point(6, 19);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(41, 23);
            this.BtnLine.TabIndex = 3;
            this.BtnLine.UseVisualStyleBackColor = false;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(466, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Brush style";
            // 
            // cmbFillMode
            // 
            this.cmbFillMode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbFillMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFillMode.DropDownHeight = 200;
            this.cmbFillMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFillMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFillMode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFillMode.FormattingEnabled = true;
            this.cmbFillMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFillMode.IntegralHeight = false;
            this.cmbFillMode.Items.AddRange(new object[] {
            "Solid",
            "LinearGradient",
            "HatchBrush",
            "NoFill"});
            this.cmbFillMode.Location = new System.Drawing.Point(546, 39);
            this.cmbFillMode.Name = "cmbFillMode";
            this.cmbFillMode.Size = new System.Drawing.Size(95, 21);
            this.cmbFillMode.TabIndex = 8;
            this.cmbFillMode.SelectedIndexChanged += new System.EventHandler(this.cmbFillMode_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label.Location = new System.Drawing.Point(489, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 16);
            this.label.TabIndex = 2;
            this.label.Text = "Outline";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ChooseCo);
            this.panel2.Controls.Add(this.DarkKhaki);
            this.panel2.Controls.Add(this.Teal);
            this.panel2.Controls.Add(this.LigthBlue);
            this.panel2.Controls.Add(this.YellowGreen);
            this.panel2.Controls.Add(this.LightYellow);
            this.panel2.Controls.Add(this.Gold);
            this.panel2.Controls.Add(this.LightCoral);
            this.panel2.Controls.Add(this.LightGray);
            this.panel2.Controls.Add(this.White);
            this.panel2.Controls.Add(this.Purple);
            this.panel2.Controls.Add(this.Blue);
            this.panel2.Controls.Add(this.Cyan);
            this.panel2.Controls.Add(this.Green);
            this.panel2.Controls.Add(this.Yellow);
            this.panel2.Controls.Add(this.Orange);
            this.panel2.Controls.Add(this.DarkRed);
            this.panel2.Controls.Add(this.Gray);
            this.panel2.Controls.Add(this.Outlineco);
            this.panel2.Controls.Add(this.Black);
            this.panel2.Controls.Add(this.BackCo);
            this.panel2.Controls.Add(this.outLineBut);
            this.panel2.Controls.Add(this.fillCoBut);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(647, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 77);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "OutLine\r\nColor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(361, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Edit\r\ncolors";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(53, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fill\r\nColor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseCo
            // 
            this.ChooseCo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChooseCo.BackgroundImage")));
            this.ChooseCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChooseCo.FlatAppearance.BorderSize = 0;
            this.ChooseCo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseCo.Location = new System.Drawing.Point(326, 3);
            this.ChooseCo.Name = "ChooseCo";
            this.ChooseCo.Size = new System.Drawing.Size(35, 50);
            this.ChooseCo.TabIndex = 23;
            this.ChooseCo.UseVisualStyleBackColor = true;
            this.ChooseCo.Click += new System.EventHandler(this.ChooseCo_Click);
            // 
            // DarkKhaki
            // 
            this.DarkKhaki.BackColor = System.Drawing.Color.DarkKhaki;
            this.DarkKhaki.ForeColor = System.Drawing.Color.DarkRed;
            this.DarkKhaki.Location = new System.Drawing.Point(294, 28);
            this.DarkKhaki.Name = "DarkKhaki";
            this.DarkKhaki.Size = new System.Drawing.Size(26, 25);
            this.DarkKhaki.TabIndex = 22;
            this.DarkKhaki.UseVisualStyleBackColor = false;
            this.DarkKhaki.Click += new System.EventHandler(this.DarkKhaki_Click);
            // 
            // Teal
            // 
            this.Teal.BackColor = System.Drawing.Color.Teal;
            this.Teal.ForeColor = System.Drawing.Color.DarkRed;
            this.Teal.Location = new System.Drawing.Point(270, 28);
            this.Teal.Name = "Teal";
            this.Teal.Size = new System.Drawing.Size(26, 25);
            this.Teal.TabIndex = 21;
            this.Teal.UseVisualStyleBackColor = false;
            this.Teal.Click += new System.EventHandler(this.Teal_Click);
            // 
            // LigthBlue
            // 
            this.LigthBlue.BackColor = System.Drawing.Color.LightBlue;
            this.LigthBlue.ForeColor = System.Drawing.Color.DarkRed;
            this.LigthBlue.Location = new System.Drawing.Point(243, 28);
            this.LigthBlue.Name = "LigthBlue";
            this.LigthBlue.Size = new System.Drawing.Size(26, 25);
            this.LigthBlue.TabIndex = 20;
            this.LigthBlue.UseVisualStyleBackColor = false;
            this.LigthBlue.Click += new System.EventHandler(this.LigthBlue_Click);
            // 
            // YellowGreen
            // 
            this.YellowGreen.BackColor = System.Drawing.Color.YellowGreen;
            this.YellowGreen.ForeColor = System.Drawing.Color.DarkRed;
            this.YellowGreen.Location = new System.Drawing.Point(218, 28);
            this.YellowGreen.Name = "YellowGreen";
            this.YellowGreen.Size = new System.Drawing.Size(26, 25);
            this.YellowGreen.TabIndex = 19;
            this.YellowGreen.UseVisualStyleBackColor = false;
            this.YellowGreen.Click += new System.EventHandler(this.YellowGreen_Click);
            // 
            // LightYellow
            // 
            this.LightYellow.BackColor = System.Drawing.Color.LightYellow;
            this.LightYellow.ForeColor = System.Drawing.Color.DarkRed;
            this.LightYellow.Location = new System.Drawing.Point(192, 27);
            this.LightYellow.Name = "LightYellow";
            this.LightYellow.Size = new System.Drawing.Size(26, 25);
            this.LightYellow.TabIndex = 18;
            this.LightYellow.UseVisualStyleBackColor = false;
            this.LightYellow.Click += new System.EventHandler(this.LightYellow_Click);
            // 
            // Gold
            // 
            this.Gold.BackColor = System.Drawing.Color.Gold;
            this.Gold.ForeColor = System.Drawing.Color.DarkRed;
            this.Gold.Location = new System.Drawing.Point(167, 27);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(26, 25);
            this.Gold.TabIndex = 17;
            this.Gold.UseVisualStyleBackColor = false;
            this.Gold.Click += new System.EventHandler(this.Gold_Click);
            // 
            // LightCoral
            // 
            this.LightCoral.BackColor = System.Drawing.Color.LightCoral;
            this.LightCoral.ForeColor = System.Drawing.Color.DarkRed;
            this.LightCoral.Location = new System.Drawing.Point(141, 27);
            this.LightCoral.Name = "LightCoral";
            this.LightCoral.Size = new System.Drawing.Size(26, 25);
            this.LightCoral.TabIndex = 16;
            this.LightCoral.UseVisualStyleBackColor = false;
            this.LightCoral.Click += new System.EventHandler(this.LightCoral_Click);
            // 
            // LightGray
            // 
            this.LightGray.BackColor = System.Drawing.Color.LightGray;
            this.LightGray.Location = new System.Drawing.Point(116, 27);
            this.LightGray.Name = "LightGray";
            this.LightGray.Size = new System.Drawing.Size(26, 25);
            this.LightGray.TabIndex = 15;
            this.LightGray.UseVisualStyleBackColor = false;
            this.LightGray.Click += new System.EventHandler(this.LightGray_Click);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(91, 27);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(26, 25);
            this.White.TabIndex = 14;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Purple;
            this.Purple.ForeColor = System.Drawing.Color.DarkRed;
            this.Purple.Location = new System.Drawing.Point(294, 3);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(26, 26);
            this.Purple.TabIndex = 13;
            this.Purple.UseVisualStyleBackColor = false;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.ForeColor = System.Drawing.Color.DarkRed;
            this.Blue.Location = new System.Drawing.Point(270, 3);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(26, 26);
            this.Blue.TabIndex = 12;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Cyan
            // 
            this.Cyan.BackColor = System.Drawing.Color.Cyan;
            this.Cyan.ForeColor = System.Drawing.Color.DarkRed;
            this.Cyan.Location = new System.Drawing.Point(243, 3);
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(26, 26);
            this.Cyan.TabIndex = 11;
            this.Cyan.UseVisualStyleBackColor = false;
            this.Cyan.Click += new System.EventHandler(this.Cyan_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.ForeColor = System.Drawing.Color.DarkRed;
            this.Green.Location = new System.Drawing.Point(218, 2);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(26, 27);
            this.Green.TabIndex = 10;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.ForeColor = System.Drawing.Color.DarkRed;
            this.Yellow.Location = new System.Drawing.Point(192, 3);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(26, 25);
            this.Yellow.TabIndex = 9;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.ForeColor = System.Drawing.Color.DarkRed;
            this.Orange.Location = new System.Drawing.Point(167, 3);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(26, 25);
            this.Orange.TabIndex = 8;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // DarkRed
            // 
            this.DarkRed.BackColor = System.Drawing.Color.DarkRed;
            this.DarkRed.ForeColor = System.Drawing.Color.DarkRed;
            this.DarkRed.Location = new System.Drawing.Point(141, 3);
            this.DarkRed.Name = "DarkRed";
            this.DarkRed.Size = new System.Drawing.Size(26, 25);
            this.DarkRed.TabIndex = 7;
            this.DarkRed.UseVisualStyleBackColor = false;
            this.DarkRed.Click += new System.EventHandler(this.DarkRed_Click);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Gray;
            this.Gray.Location = new System.Drawing.Point(116, 3);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(26, 25);
            this.Gray.TabIndex = 6;
            this.Gray.UseVisualStyleBackColor = false;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Outlineco
            // 
            this.Outlineco.BackColor = System.Drawing.SystemColors.MenuText;
            this.Outlineco.FlatAppearance.BorderSize = 0;
            this.Outlineco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Outlineco.Location = new System.Drawing.Point(8, 3);
            this.Outlineco.Name = "Outlineco";
            this.Outlineco.Size = new System.Drawing.Size(39, 37);
            this.Outlineco.TabIndex = 0;
            this.Outlineco.UseVisualStyleBackColor = false;
            this.Outlineco.BackColorChanged += new System.EventHandler(this.Outlineco_BackColorChanged);
            this.Outlineco.Click += new System.EventHandler(this.Outlineco_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(91, 3);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(26, 25);
            this.Black.TabIndex = 5;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // BackCo
            // 
            this.BackCo.BackColor = System.Drawing.Color.White;
            this.BackCo.FlatAppearance.BorderSize = 0;
            this.BackCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackCo.Location = new System.Drawing.Point(52, 6);
            this.BackCo.Name = "BackCo";
            this.BackCo.Size = new System.Drawing.Size(33, 30);
            this.BackCo.TabIndex = 4;
            this.BackCo.UseVisualStyleBackColor = false;
            this.BackCo.BackColorChanged += new System.EventHandler(this.BackCo_BackColorChanged);
            this.BackCo.Click += new System.EventHandler(this.BackCo_Click);
            // 
            // outLineBut
            // 
            this.outLineBut.BackColor = System.Drawing.Color.Transparent;
            this.outLineBut.FlatAppearance.BorderSize = 0;
            this.outLineBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.outLineBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.outLineBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outLineBut.Location = new System.Drawing.Point(3, 1);
            this.outLineBut.Name = "outLineBut";
            this.outLineBut.Size = new System.Drawing.Size(48, 69);
            this.outLineBut.TabIndex = 26;
            this.outLineBut.UseVisualStyleBackColor = false;
            // 
            // fillCoBut
            // 
            this.fillCoBut.BackColor = System.Drawing.Color.Transparent;
            this.fillCoBut.FlatAppearance.BorderSize = 0;
            this.fillCoBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fillCoBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fillCoBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillCoBut.Location = new System.Drawing.Point(50, 2);
            this.fillCoBut.Name = "fillCoBut";
            this.fillCoBut.Size = new System.Drawing.Size(40, 69);
            this.fillCoBut.TabIndex = 27;
            this.fillCoBut.UseVisualStyleBackColor = false;
            // 
            // cmbOutline
            // 
            this.cmbOutline.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbOutline.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbOutline.DropDownHeight = 200;
            this.cmbOutline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOutline.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOutline.FormattingEnabled = true;
            this.cmbOutline.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbOutline.IntegralHeight = false;
            this.cmbOutline.Items.AddRange(new object[] {
            "Solid",
            "Dot",
            "Dash",
            "Dashdotdot",
            "Custom"});
            this.cmbOutline.Location = new System.Drawing.Point(546, 12);
            this.cmbOutline.Name = "cmbOutline";
            this.cmbOutline.Size = new System.Drawing.Size(95, 21);
            this.cmbOutline.TabIndex = 1;
            this.cmbOutline.SelectedIndexChanged += new System.EventHandler(this.cmbOutline_SelectedIndexChanged);
            // 
            // plHatchBrush
            // 
            this.plHatchBrush.BackColor = System.Drawing.Color.Gainsboro;
            this.plHatchBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plHatchBrush.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plHatchBrush.Controls.Add(this.cmbLinear);
            this.plHatchBrush.Controls.Add(this.p);
            this.plHatchBrush.Controls.Add(this.cmbHatchBrush);
            this.plHatchBrush.Controls.Add(this.lbBrush);
            this.plHatchBrush.Location = new System.Drawing.Point(1073, 91);
            this.plHatchBrush.Name = "plHatchBrush";
            this.plHatchBrush.Size = new System.Drawing.Size(159, 238);
            this.plHatchBrush.TabIndex = 2;
            this.plHatchBrush.Visible = false;
            // 
            // cmbLinear
            // 
            this.cmbLinear.FormattingEnabled = true;
            this.cmbLinear.Items.AddRange(new object[] {
            "BackwardDiagonal",
            "Vertical",
            "ForwardDiagonal",
            "Horizontal"});
            this.cmbLinear.Location = new System.Drawing.Point(6, 77);
            this.cmbLinear.Name = "cmbLinear";
            this.cmbLinear.Size = new System.Drawing.Size(142, 21);
            this.cmbLinear.TabIndex = 0;
            // 
            // p
            // 
            this.p.Controls.Add(this.btnCl2Hatch);
            this.p.Controls.Add(this.btnCl1Hatch);
            this.p.Controls.Add(this.label7);
            this.p.Controls.Add(this.label6);
            this.p.Enabled = false;
            this.p.Location = new System.Drawing.Point(6, 105);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(142, 99);
            this.p.TabIndex = 16;
            // 
            // btnCl2Hatch
            // 
            this.btnCl2Hatch.BackColor = System.Drawing.Color.DarkRed;
            this.btnCl2Hatch.Location = new System.Drawing.Point(60, 36);
            this.btnCl2Hatch.Name = "btnCl2Hatch";
            this.btnCl2Hatch.Size = new System.Drawing.Size(31, 33);
            this.btnCl2Hatch.TabIndex = 28;
            this.btnCl2Hatch.UseVisualStyleBackColor = false;
            this.btnCl2Hatch.Click += new System.EventHandler(this.btnCl2Hatch_Click);
            // 
            // btnCl1Hatch
            // 
            this.btnCl1Hatch.BackColor = System.Drawing.Color.White;
            this.btnCl1Hatch.Location = new System.Drawing.Point(60, 0);
            this.btnCl1Hatch.Name = "btnCl1Hatch";
            this.btnCl1Hatch.Size = new System.Drawing.Size(31, 33);
            this.btnCl1Hatch.TabIndex = 26;
            this.btnCl1Hatch.UseVisualStyleBackColor = false;
            this.btnCl1Hatch.Click += new System.EventHandler(this.btnCl1Hatch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Color 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Color 1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbHatchBrush
            // 
            this.cmbHatchBrush.FormattingEnabled = true;
            this.cmbHatchBrush.Items.AddRange(new object[] {
            "BackwardDiagonal",
            "DiagonalCross",
            "HorizontalBrick",
            "LightDownwardDiagonal"});
            this.cmbHatchBrush.Location = new System.Drawing.Point(6, 77);
            this.cmbHatchBrush.Name = "cmbHatchBrush";
            this.cmbHatchBrush.Size = new System.Drawing.Size(142, 21);
            this.cmbHatchBrush.TabIndex = 15;
            this.cmbHatchBrush.SelectedIndexChanged += new System.EventHandler(this.cmbHatchBrush_SelectedIndexChanged);
            // 
            // lbBrush
            // 
            this.lbBrush.AutoSize = true;
            this.lbBrush.BackColor = System.Drawing.Color.Maroon;
            this.lbBrush.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrush.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBrush.Location = new System.Drawing.Point(18, 10);
            this.lbBrush.Name = "lbBrush";
            this.lbBrush.Size = new System.Drawing.Size(114, 18);
            this.lbBrush.TabIndex = 14;
            this.lbBrush.Text = "HatchBrush Style";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(96, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plMain
            // 
            this.plMain.AutoScroll = true;
            this.plMain.BackColor = System.Drawing.Color.White;
            this.plMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.plMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plMain.Location = new System.Drawing.Point(3, 91);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1070, 649);
            this.plMain.TabIndex = 1;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.DoubleClick += new System.EventHandler(this.plMain_DoubleClick);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1236, 634);
            this.Controls.Add(this.plHatchBrush);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackLinewidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.plHatchBrush.ResumeLayout(false);
            this.plHatchBrush.PerformLayout();
            this.p.ResumeLayout(false);
            this.p.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DoubleBufferPanel plMain;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cmbOutline;
        private System.Windows.Forms.Button Outlineco;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChooseCo;
        private System.Windows.Forms.Button DarkKhaki;
        private System.Windows.Forms.Button Teal;
        private System.Windows.Forms.Button LigthBlue;
        private System.Windows.Forms.Button YellowGreen;
        private System.Windows.Forms.Button LightYellow;
        private System.Windows.Forms.Button Gold;
        private System.Windows.Forms.Button LightCoral;
        private System.Windows.Forms.Button LightGray;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Cyan;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button DarkRed;
        private System.Windows.Forms.Button Gray;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button BackCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFillMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnPol;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnElip;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Panel plHatchBrush;
        private System.Windows.Forms.Panel p;
        private System.Windows.Forms.Button btnCl2Hatch;
        private System.Windows.Forms.Button btnCl1Hatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHatchBrush;
        private System.Windows.Forms.Label lbBrush;
        private System.Windows.Forms.Button outLineBut;
        private System.Windows.Forms.Button fillCoBut;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.TrackBar trackLinewidth;
        private System.Windows.Forms.ComboBox cmbLinear;
        private System.Windows.Forms.Button btnungroup;
        private System.Windows.Forms.Button btngroup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

