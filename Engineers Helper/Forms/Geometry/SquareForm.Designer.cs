namespace Engineers_Helper.Forms.Geometry
{
    partial class SquareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SquareForm));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.pictureBox_Screan = new System.Windows.Forms.PictureBox();
            this.textBox_Side = new System.Windows.Forms.TextBox();
            this.label_Side = new System.Windows.Forms.Label();
            this.label_Perimeter = new System.Windows.Forms.Label();
            this.textBox_Perimeter = new System.Windows.Forms.TextBox();
            this.label_Area = new System.Windows.Forms.Label();
            this.textBox_Area = new System.Windows.Forms.TextBox();
            this.Label_Header = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.richTextBox_InradiusFormula = new System.Windows.Forms.RichTextBox();
            this.label_InradiusFormula = new System.Windows.Forms.Label();
            this.richTextBox_CircumradiusFormula = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_AreaFormula = new System.Windows.Forms.RichTextBox();
            this.label_AreaFormula = new System.Windows.Forms.Label();
            this.richTextBox_PerimeterFormula = new System.Windows.Forms.RichTextBox();
            this.label_PerimeterFormula = new System.Windows.Forms.Label();
            this.richTextBox_DiagonalFormula = new System.Windows.Forms.RichTextBox();
            this.label_DiagonalFormula = new System.Windows.Forms.Label();
            this.richTextBox_Properties = new System.Windows.Forms.RichTextBox();
            this.label_Properties = new System.Windows.Forms.Label();
            this.richTextBox_Definition = new System.Windows.Forms.RichTextBox();
            this.label_Definition = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            this.label_InsideRadius = new System.Windows.Forms.Label();
            this.textBox_IsideRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_OutsideRadius = new System.Windows.Forms.TextBox();
            this.label_Diagonal = new System.Windows.Forms.Label();
            this.textBox_Diagonal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screan)).BeginInit();
            this.panel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Back.FlatAppearance.BorderSize = 0;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Back.Image")));
            this.Btn_Back.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Back.MaximumSize = new System.Drawing.Size(58, 0);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(58, 808);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // pictureBox_Screan
            // 
            this.pictureBox_Screan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Screan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Screan.Image")));
            this.pictureBox_Screan.Location = new System.Drawing.Point(163, 137);
            this.pictureBox_Screan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox_Screan.Name = "pictureBox_Screan";
            this.pictureBox_Screan.Size = new System.Drawing.Size(387, 352);
            this.pictureBox_Screan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Screan.TabIndex = 1;
            this.pictureBox_Screan.TabStop = false;
            // 
            // textBox_Side
            // 
            this.textBox_Side.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Side.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Side.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Side.Location = new System.Drawing.Point(582, 152);
            this.textBox_Side.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Side.Name = "textBox_Side";
            this.textBox_Side.Size = new System.Drawing.Size(247, 40);
            this.textBox_Side.TabIndex = 3;
            this.textBox_Side.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Side
            // 
            this.label_Side.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Side.AutoSize = true;
            this.label_Side.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Side.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Side.Location = new System.Drawing.Point(579, 122);
            this.label_Side.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Side.Name = "label_Side";
            this.label_Side.Size = new System.Drawing.Size(60, 16);
            this.label_Side.TabIndex = 4;
            this.label_Side.Text = "Side - a";
            // 
            // label_Perimeter
            // 
            this.label_Perimeter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Perimeter.AutoSize = true;
            this.label_Perimeter.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Perimeter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Perimeter.Location = new System.Drawing.Point(579, 210);
            this.label_Perimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Perimeter.Name = "label_Perimeter";
            this.label_Perimeter.Size = new System.Drawing.Size(94, 16);
            this.label_Perimeter.TabIndex = 6;
            this.label_Perimeter.Text = "Perimeter - P";
            // 
            // textBox_Perimeter
            // 
            this.textBox_Perimeter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Perimeter.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Perimeter.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Perimeter.Location = new System.Drawing.Point(582, 240);
            this.textBox_Perimeter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Perimeter.Name = "textBox_Perimeter";
            this.textBox_Perimeter.Size = new System.Drawing.Size(247, 40);
            this.textBox_Perimeter.TabIndex = 5;
            this.textBox_Perimeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Area
            // 
            this.label_Area.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Area.AutoSize = true;
            this.label_Area.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Area.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Area.Location = new System.Drawing.Point(579, 385);
            this.label_Area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(63, 16);
            this.label_Area.TabIndex = 8;
            this.label_Area.Text = "Area - A";
            // 
            // textBox_Area
            // 
            this.textBox_Area.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Area.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Area.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Area.Location = new System.Drawing.Point(582, 415);
            this.textBox_Area.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Area.Name = "textBox_Area";
            this.textBox_Area.Size = new System.Drawing.Size(247, 40);
            this.textBox_Area.TabIndex = 7;
            this.textBox_Area.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Header
            // 
            this.Label_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Header.AutoSize = true;
            this.Label_Header.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Header.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Header.Location = new System.Drawing.Point(289, 137);
            this.Label_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Header.Name = "Label_Header";
            this.Label_Header.Size = new System.Drawing.Size(143, 42);
            this.Label_Header.TabIndex = 9;
            this.Label_Header.Text = "Square";
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Clear.AutoSize = true;
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Clear.Location = new System.Drawing.Point(565, 666);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(128, 52);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Calculate
            // 
            this.button_Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Calculate.AutoSize = true;
            this.button_Calculate.FlatAppearance.BorderSize = 0;
            this.button_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calculate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Calculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Calculate.Location = new System.Drawing.Point(715, 666);
            this.button_Calculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(128, 52);
            this.button_Calculate.TabIndex = 11;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // button_Info
            // 
            this.button_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Info.FlatAppearance.BorderSize = 0;
            this.button_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Info.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Info.Image = ((System.Drawing.Image)(resources.GetObject("button_Info.Image")));
            this.button_Info.Location = new System.Drawing.Point(1342, 0);
            this.button_Info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(58, 808);
            this.button_Info.TabIndex = 12;
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.AutoScroll = true;
            this.panel_Info.Controls.Add(this.richTextBox_InradiusFormula);
            this.panel_Info.Controls.Add(this.label_InradiusFormula);
            this.panel_Info.Controls.Add(this.richTextBox_CircumradiusFormula);
            this.panel_Info.Controls.Add(this.label1);
            this.panel_Info.Controls.Add(this.richTextBox_AreaFormula);
            this.panel_Info.Controls.Add(this.label_AreaFormula);
            this.panel_Info.Controls.Add(this.richTextBox_PerimeterFormula);
            this.panel_Info.Controls.Add(this.label_PerimeterFormula);
            this.panel_Info.Controls.Add(this.richTextBox_DiagonalFormula);
            this.panel_Info.Controls.Add(this.label_DiagonalFormula);
            this.panel_Info.Controls.Add(this.richTextBox_Properties);
            this.panel_Info.Controls.Add(this.label_Properties);
            this.panel_Info.Controls.Add(this.richTextBox_Definition);
            this.panel_Info.Controls.Add(this.label_Definition);
            this.panel_Info.Controls.Add(this.label_Info);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Info.Location = new System.Drawing.Point(934, 0);
            this.panel_Info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.panel_Info.Size = new System.Drawing.Size(408, 808);
            this.panel_Info.TabIndex = 13;
            this.panel_Info.Visible = false;
            // 
            // richTextBox_InradiusFormula
            // 
            this.richTextBox_InradiusFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.richTextBox_InradiusFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_InradiusFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_InradiusFormula.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_InradiusFormula.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_InradiusFormula.Location = new System.Drawing.Point(5, 1383);
            this.richTextBox_InradiusFormula.Name = "richTextBox_InradiusFormula";
            this.richTextBox_InradiusFormula.Size = new System.Drawing.Size(386, 131);
            this.richTextBox_InradiusFormula.TabIndex = 2;
            this.richTextBox_InradiusFormula.Text = "Using square side:\t\t r = a / 2\nUsing square diagonal:\t r = d / 2√2\nUsing square p" +
    "erimeter:\t r = P / 8\nUsingsquare area: \t\t r = √A / 2\nUsing circumradius: \t\t r = " +
    "R √2";
            this.richTextBox_InradiusFormula.Visible = false;
            // 
            // label_InradiusFormula
            // 
            this.label_InradiusFormula.AutoSize = true;
            this.label_InradiusFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_InradiusFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_InradiusFormula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_InradiusFormula.Location = new System.Drawing.Point(5, 1340);
            this.label_InradiusFormula.Name = "label_InradiusFormula";
            this.label_InradiusFormula.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_InradiusFormula.Size = new System.Drawing.Size(277, 43);
            this.label_InradiusFormula.TabIndex = 1;
            this.label_InradiusFormula.Text = "Inradius of square formulas";
            this.label_InradiusFormula.Click += new System.EventHandler(this.label_InradiusFormula_Click);
            // 
            // richTextBox_CircumradiusFormula
            // 
            this.richTextBox_CircumradiusFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.richTextBox_CircumradiusFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_CircumradiusFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_CircumradiusFormula.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_CircumradiusFormula.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_CircumradiusFormula.Location = new System.Drawing.Point(5, 1209);
            this.richTextBox_CircumradiusFormula.Name = "richTextBox_CircumradiusFormula";
            this.richTextBox_CircumradiusFormula.Size = new System.Drawing.Size(386, 131);
            this.richTextBox_CircumradiusFormula.TabIndex = 2;
            this.richTextBox_CircumradiusFormula.Text = "Using square side:\t\tR = a  (√2 / 2)\nUsing square perimeter:\tR = P  /  4√2\nUsing s" +
    "quare area:\t\tR = √2A / 2\nUsing square diagonal: \tR = d / 2\nUsing inradius: \t\t \tR" +
    " = r √2";
            this.richTextBox_CircumradiusFormula.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(5, 1166);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Size = new System.Drawing.Size(342, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Circumradius of a square formulas";
            this.label1.Click += new System.EventHandler(this.label_CircumradiusFormula_Click);
            // 
            // richTextBox_AreaFormula
            // 
            this.richTextBox_AreaFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.richTextBox_AreaFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_AreaFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_AreaFormula.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_AreaFormula.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_AreaFormula.Location = new System.Drawing.Point(5, 1035);
            this.richTextBox_AreaFormula.Name = "richTextBox_AreaFormula";
            this.richTextBox_AreaFormula.Size = new System.Drawing.Size(386, 131);
            this.richTextBox_AreaFormula.TabIndex = 2;
            this.richTextBox_AreaFormula.Text = "Using square side: \t\tA = a²\nUsing square perimeter:\tA = P²/16\nUsing square diagon" +
    "al: \tA = d²/2\nUsing circumradius: \t\tA = 2R²\nUsing inradius: \t\t\tA = 4r²";
            this.richTextBox_AreaFormula.Visible = false;
            // 
            // label_AreaFormula
            // 
            this.label_AreaFormula.AutoSize = true;
            this.label_AreaFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_AreaFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_AreaFormula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_AreaFormula.Location = new System.Drawing.Point(5, 992);
            this.label_AreaFormula.Name = "label_AreaFormula";
            this.label_AreaFormula.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_AreaFormula.Size = new System.Drawing.Size(259, 43);
            this.label_AreaFormula.TabIndex = 1;
            this.label_AreaFormula.Text = "Area of a square formulas";
            this.label_AreaFormula.Click += new System.EventHandler(this.label_AreaFormula_Click);
            // 
            // richTextBox_PerimeterFormula
            // 
            this.richTextBox_PerimeterFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.richTextBox_PerimeterFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_PerimeterFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_PerimeterFormula.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_PerimeterFormula.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_PerimeterFormula.Location = new System.Drawing.Point(5, 861);
            this.richTextBox_PerimeterFormula.Name = "richTextBox_PerimeterFormula";
            this.richTextBox_PerimeterFormula.Size = new System.Drawing.Size(386, 131);
            this.richTextBox_PerimeterFormula.TabIndex = 2;
            this.richTextBox_PerimeterFormula.Text = "Using square side:\t\tP = 4a\nUsing square area: \t  \tP = 4√A\nUsing square diagonal: " +
    "\tP = 2d√2\nUsing circumradius: \t\tP = 4R√2\nUsing inradius: \t\t \tP = 8r";
            this.richTextBox_PerimeterFormula.Visible = false;
            // 
            // label_PerimeterFormula
            // 
            this.label_PerimeterFormula.AutoSize = true;
            this.label_PerimeterFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_PerimeterFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PerimeterFormula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_PerimeterFormula.Location = new System.Drawing.Point(5, 818);
            this.label_PerimeterFormula.Name = "label_PerimeterFormula";
            this.label_PerimeterFormula.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_PerimeterFormula.Size = new System.Drawing.Size(307, 43);
            this.label_PerimeterFormula.TabIndex = 1;
            this.label_PerimeterFormula.Text = "Perimeter of a square formulas";
            this.label_PerimeterFormula.Click += new System.EventHandler(this.label_PerimeterFormula_Click);
            // 
            // richTextBox_DiagonalFormula
            // 
            this.richTextBox_DiagonalFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.richTextBox_DiagonalFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_DiagonalFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_DiagonalFormula.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_DiagonalFormula.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_DiagonalFormula.Location = new System.Drawing.Point(5, 687);
            this.richTextBox_DiagonalFormula.Name = "richTextBox_DiagonalFormula";
            this.richTextBox_DiagonalFormula.Size = new System.Drawing.Size(386, 131);
            this.richTextBox_DiagonalFormula.TabIndex = 2;
            this.richTextBox_DiagonalFormula.Text = "Using square side: \t\td = a·√2\nUsing square area:\t \td = √2A\nUsing square perimeter" +
    ": \td = P2√2\nUsing circumradius: \t\td = 2R\nUsing  inradius: \t\t\td = 2r√2";
            this.richTextBox_DiagonalFormula.Visible = false;
            // 
            // label_DiagonalFormula
            // 
            this.label_DiagonalFormula.AutoSize = true;
            this.label_DiagonalFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DiagonalFormula.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DiagonalFormula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_DiagonalFormula.Location = new System.Drawing.Point(5, 644);
            this.label_DiagonalFormula.Name = "label_DiagonalFormula";
            this.label_DiagonalFormula.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_DiagonalFormula.Size = new System.Drawing.Size(301, 43);
            this.label_DiagonalFormula.TabIndex = 1;
            this.label_DiagonalFormula.Text = "Diagonal of a square formulas";
            this.label_DiagonalFormula.Click += new System.EventHandler(this.label_DiagonalFormula_Click);
            // 
            // richTextBox_Properties
            // 
            this.richTextBox_Properties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.richTextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Properties.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_Properties.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_Properties.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_Properties.Location = new System.Drawing.Point(5, 233);
            this.richTextBox_Properties.Name = "richTextBox_Properties";
            this.richTextBox_Properties.Size = new System.Drawing.Size(386, 411);
            this.richTextBox_Properties.TabIndex = 2;
            this.richTextBox_Properties.Text = resources.GetString("richTextBox_Properties.Text");
            this.richTextBox_Properties.Visible = false;
            // 
            // label_Properties
            // 
            this.label_Properties.AutoSize = true;
            this.label_Properties.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Properties.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Properties.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Properties.Location = new System.Drawing.Point(5, 190);
            this.label_Properties.Name = "label_Properties";
            this.label_Properties.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_Properties.Size = new System.Drawing.Size(212, 43);
            this.label_Properties.TabIndex = 1;
            this.label_Properties.Text = "Properties of square:";
            this.label_Properties.Click += new System.EventHandler(this.label_Properties_Click);
            // 
            // richTextBox_Definition
            // 
            this.richTextBox_Definition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.richTextBox_Definition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Definition.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_Definition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_Definition.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_Definition.Location = new System.Drawing.Point(5, 84);
            this.richTextBox_Definition.Name = "richTextBox_Definition";
            this.richTextBox_Definition.Size = new System.Drawing.Size(386, 106);
            this.richTextBox_Definition.TabIndex = 2;
            this.richTextBox_Definition.Text = "Square is a regular quadrilateral in which all four sides and angles are equal. S" +
    "quares differ only in sides length but all four angles is right angles.";
            this.richTextBox_Definition.Visible = false;
            // 
            // label_Definition
            // 
            this.label_Definition.AutoSize = true;
            this.label_Definition.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Definition.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Definition.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Definition.Location = new System.Drawing.Point(5, 41);
            this.label_Definition.Name = "label_Definition";
            this.label_Definition.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_Definition.Size = new System.Drawing.Size(113, 43);
            this.label_Definition.TabIndex = 1;
            this.label_Definition.Text = "Definition:";
            this.label_Definition.Click += new System.EventHandler(this.label_Definition_Click);
            // 
            // label_Info
            // 
            this.label_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Info.Location = new System.Drawing.Point(5, 0);
            this.label_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(386, 41);
            this.label_Info.TabIndex = 0;
            this.label_Info.Text = "Info";
            this.label_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_InsideRadius
            // 
            this.label_InsideRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_InsideRadius.AutoSize = true;
            this.label_InsideRadius.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_InsideRadius.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_InsideRadius.Location = new System.Drawing.Point(579, 473);
            this.label_InsideRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_InsideRadius.Name = "label_InsideRadius";
            this.label_InsideRadius.Size = new System.Drawing.Size(115, 16);
            this.label_InsideRadius.TabIndex = 15;
            this.label_InsideRadius.Text = "Inside Radius - r";
            // 
            // textBox_IsideRadius
            // 
            this.textBox_IsideRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_IsideRadius.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_IsideRadius.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_IsideRadius.Location = new System.Drawing.Point(582, 503);
            this.textBox_IsideRadius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_IsideRadius.Name = "textBox_IsideRadius";
            this.textBox_IsideRadius.Size = new System.Drawing.Size(247, 40);
            this.textBox_IsideRadius.TabIndex = 14;
            this.textBox_IsideRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(579, 561);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Outside Radius - R";
            // 
            // textBox_OutsideRadius
            // 
            this.textBox_OutsideRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OutsideRadius.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_OutsideRadius.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_OutsideRadius.Location = new System.Drawing.Point(582, 591);
            this.textBox_OutsideRadius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_OutsideRadius.Name = "textBox_OutsideRadius";
            this.textBox_OutsideRadius.Size = new System.Drawing.Size(247, 40);
            this.textBox_OutsideRadius.TabIndex = 16;
            this.textBox_OutsideRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Diagonal
            // 
            this.label_Diagonal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Diagonal.AutoSize = true;
            this.label_Diagonal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Diagonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Diagonal.Location = new System.Drawing.Point(579, 298);
            this.label_Diagonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Diagonal.Name = "label_Diagonal";
            this.label_Diagonal.Size = new System.Drawing.Size(87, 16);
            this.label_Diagonal.TabIndex = 19;
            this.label_Diagonal.Text = "Diagonal - d";
            // 
            // textBox_Diagonal
            // 
            this.textBox_Diagonal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Diagonal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Diagonal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Diagonal.Location = new System.Drawing.Point(582, 328);
            this.textBox_Diagonal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Diagonal.Name = "textBox_Diagonal";
            this.textBox_Diagonal.Size = new System.Drawing.Size(247, 40);
            this.textBox_Diagonal.TabIndex = 18;
            this.textBox_Diagonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1400, 808);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_Diagonal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_OutsideRadius);
            this.Controls.Add(this.label_InsideRadius);
            this.Controls.Add(this.textBox_IsideRadius);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.Label_Header);
            this.Controls.Add(this.label_Area);
            this.Controls.Add(this.textBox_Area);
            this.Controls.Add(this.label_Perimeter);
            this.Controls.Add(this.textBox_Perimeter);
            this.Controls.Add(this.label_Side);
            this.Controls.Add(this.textBox_Side);
            this.Controls.Add(this.pictureBox_Screan);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.textBox_Diagonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(933, 692);
            this.Name = "SquareForm";
            this.Text = "Square";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screan)).EndInit();
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.PictureBox pictureBox_Screan;
        private System.Windows.Forms.TextBox textBox_Side;
        private System.Windows.Forms.Label label_Side;
        private System.Windows.Forms.Label label_Perimeter;
        private System.Windows.Forms.TextBox textBox_Perimeter;
        private System.Windows.Forms.Label label_Area;
        private System.Windows.Forms.TextBox textBox_Area;
        private System.Windows.Forms.Label Label_Header;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label label_InsideRadius;
        private System.Windows.Forms.TextBox textBox_IsideRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_OutsideRadius;
        private System.Windows.Forms.Label label_Diagonal;
        private System.Windows.Forms.TextBox textBox_Diagonal;
        private System.Windows.Forms.RichTextBox richTextBox_Definition;
        private System.Windows.Forms.Label label_Definition;
        private System.Windows.Forms.RichTextBox richTextBox_Properties;
        private System.Windows.Forms.Label label_Properties;
        private System.Windows.Forms.RichTextBox richTextBox_DiagonalFormula;
        private System.Windows.Forms.Label label_DiagonalFormula;
        private System.Windows.Forms.RichTextBox richTextBox_PerimeterFormula;
        private System.Windows.Forms.Label label_PerimeterFormula;
        private System.Windows.Forms.Label label_AreaFormula;
        private System.Windows.Forms.RichTextBox richTextBox_AreaFormula;
        private System.Windows.Forms.RichTextBox richTextBox_CircumradiusFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_InradiusFormula;
        private System.Windows.Forms.Label label_InradiusFormula;
    }
}