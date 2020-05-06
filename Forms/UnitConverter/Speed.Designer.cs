namespace Forms.UnitConverter
{
    partial class Speed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speed));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_FromUnit = new System.Windows.Forms.ComboBox();
            this.label_FromUnit = new System.Windows.Forms.Label();
            this.label_ToUnit = new System.Windows.Forms.Label();
            this.button_Convert = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.comboBox_ToUnit = new System.Windows.Forms.ComboBox();
            this.textBox_FromUnit = new System.Windows.Forms.TextBox();
            this.textBox_ToUnit = new System.Windows.Forms.TextBox();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_KeyboardMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Keyboard = new System.Windows.Forms.TableLayoutPanel();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_Enter = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_Backspace = new System.Windows.Forms.Button();
            this.button1_Dot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.tableLayoutPanel_Keyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 622);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_FromUnit
            // 
            this.comboBox_FromUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_FromUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "Mile",
            "Kilometre",
            "Metre",
            "Feets"});
            this.comboBox_FromUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.comboBox_FromUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FromUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_FromUnit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FromUnit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox_FromUnit.FormattingEnabled = true;
            this.comboBox_FromUnit.Items.AddRange(new object[] {
            "Mile per hour",
            "Feet per second",
            "Metre per second",
            "Kilometre per hour",
            "Knot"});
            this.comboBox_FromUnit.Location = new System.Drawing.Point(158, 256);
            this.comboBox_FromUnit.Name = "comboBox_FromUnit";
            this.comboBox_FromUnit.Size = new System.Drawing.Size(220, 33);
            this.comboBox_FromUnit.TabIndex = 1;
            this.comboBox_FromUnit.Click += new System.EventHandler(this.comboBox_FromUnit_Click);
            // 
            // label_FromUnit
            // 
            this.label_FromUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FromUnit.AutoSize = true;
            this.label_FromUnit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FromUnit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_FromUnit.Location = new System.Drawing.Point(216, 166);
            this.label_FromUnit.Name = "label_FromUnit";
            this.label_FromUnit.Size = new System.Drawing.Size(105, 23);
            this.label_FromUnit.TabIndex = 3;
            this.label_FromUnit.Text = "From Unit";
            // 
            // label_ToUnit
            // 
            this.label_ToUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ToUnit.AutoSize = true;
            this.label_ToUnit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ToUnit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ToUnit.Location = new System.Drawing.Point(665, 166);
            this.label_ToUnit.Name = "label_ToUnit";
            this.label_ToUnit.Size = new System.Drawing.Size(78, 23);
            this.label_ToUnit.TabIndex = 4;
            this.label_ToUnit.Text = "To Unit";
            // 
            // button_Convert
            // 
            this.button_Convert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Convert.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Convert.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Convert.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Convert.Image = ((System.Drawing.Image)(resources.GetObject("button_Convert.Image")));
            this.button_Convert.Location = new System.Drawing.Point(351, 389);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(141, 50);
            this.button_Convert.TabIndex = 5;
            this.button_Convert.Text = "C&onvert";
            this.button_Convert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Convert.UseVisualStyleBackColor = true;
            this.button_Convert.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Clear.Image = ((System.Drawing.Image)(resources.GetObject("button_Clear.Image")));
            this.button_Clear.Location = new System.Drawing.Point(498, 389);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_Clear.Size = new System.Drawing.Size(141, 50);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "&Clear";
            this.button_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // comboBox_ToUnit
            // 
            this.comboBox_ToUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_ToUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "Mile",
            "Kilometre",
            "Metre",
            "Feets"});
            this.comboBox_ToUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.comboBox_ToUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ToUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_ToUnit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ToUnit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox_ToUnit.FormattingEnabled = true;
            this.comboBox_ToUnit.Items.AddRange(new object[] {
            "Mile per hour",
            "Feet per second",
            "Metre per second",
            "Kilometre per hour",
            "Knot"});
            this.comboBox_ToUnit.Location = new System.Drawing.Point(594, 256);
            this.comboBox_ToUnit.Name = "comboBox_ToUnit";
            this.comboBox_ToUnit.Size = new System.Drawing.Size(220, 33);
            this.comboBox_ToUnit.TabIndex = 7;
            this.comboBox_ToUnit.Click += new System.EventHandler(this.comboBox_ToUnit_Click);
            // 
            // textBox_FromUnit
            // 
            this.textBox_FromUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FromUnit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_FromUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_FromUnit.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FromUnit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_FromUnit.Location = new System.Drawing.Point(158, 203);
            this.textBox_FromUnit.MaxLength = 6;
            this.textBox_FromUnit.Name = "textBox_FromUnit";
            this.textBox_FromUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_FromUnit.Size = new System.Drawing.Size(220, 33);
            this.textBox_FromUnit.TabIndex = 8;
            this.textBox_FromUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_FromUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_FromUnit_KeyPress);
            // 
            // textBox_ToUnit
            // 
            this.textBox_ToUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ToUnit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_ToUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ToUnit.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ToUnit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_ToUnit.Location = new System.Drawing.Point(594, 203);
            this.textBox_ToUnit.MaxLength = 6;
            this.textBox_ToUnit.Name = "textBox_ToUnit";
            this.textBox_ToUnit.ReadOnly = true;
            this.textBox_ToUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_ToUnit.Size = new System.Drawing.Size(220, 33);
            this.textBox_ToUnit.TabIndex = 9;
            this.textBox_ToUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(437, 203);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(117, 72);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 10;
            this.pictureBox_Logo.TabStop = false;
            // 
            // button_KeyboardMenu
            // 
            this.button_KeyboardMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_KeyboardMenu.FlatAppearance.BorderSize = 0;
            this.button_KeyboardMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KeyboardMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_KeyboardMenu.Image = ((System.Drawing.Image)(resources.GetObject("button_KeyboardMenu.Image")));
            this.button_KeyboardMenu.Location = new System.Drawing.Point(50, 572);
            this.button_KeyboardMenu.Name = "button_KeyboardMenu";
            this.button_KeyboardMenu.Size = new System.Drawing.Size(909, 50);
            this.button_KeyboardMenu.TabIndex = 11;
            this.button_KeyboardMenu.UseVisualStyleBackColor = true;
            this.button_KeyboardMenu.Click += new System.EventHandler(this.button_KeyboardMenu_Click);
            // 
            // tableLayoutPanel_Keyboard
            // 
            this.tableLayoutPanel_Keyboard.AllowDrop = true;
            this.tableLayoutPanel_Keyboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel_Keyboard.ColumnCount = 7;
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_CE, 5, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_Enter, 6, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_7, 0, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_6, 0, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_8, 0, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_0, 0, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_9, 0, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_5, 4, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_4, 3, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_3, 2, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_2, 1, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_1, 0, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button_Backspace, 5, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button1_Dot, 6, 0);
            this.tableLayoutPanel_Keyboard.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_Keyboard.Location = new System.Drawing.Point(225, 466);
            this.tableLayoutPanel_Keyboard.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.tableLayoutPanel_Keyboard.Name = "tableLayoutPanel_Keyboard";
            this.tableLayoutPanel_Keyboard.RowCount = 2;
            this.tableLayoutPanel_Keyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Keyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Keyboard.Size = new System.Drawing.Size(563, 100);
            this.tableLayoutPanel_Keyboard.TabIndex = 12;
            // 
            // button_CE
            // 
            this.button_CE.FlatAppearance.BorderSize = 0;
            this.button_CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_CE.Location = new System.Drawing.Point(403, 53);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(74, 44);
            this.button_CE.TabIndex = 20;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_Enter
            // 
            this.button_Enter.FlatAppearance.BorderSize = 0;
            this.button_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Enter.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Enter.Location = new System.Drawing.Point(483, 53);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(75, 44);
            this.button_Enter.TabIndex = 19;
            this.button_Enter.Text = "⎆";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // button_7
            // 
            this.button_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_7.FlatAppearance.BorderSize = 0;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_7.Location = new System.Drawing.Point(83, 53);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(74, 44);
            this.button_7.TabIndex = 17;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_6
            // 
            this.button_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_6.FlatAppearance.BorderSize = 0;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_6.Location = new System.Drawing.Point(3, 53);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(74, 44);
            this.button_6.TabIndex = 16;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_8
            // 
            this.button_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_8.FlatAppearance.BorderSize = 0;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_8.Location = new System.Drawing.Point(163, 53);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(74, 44);
            this.button_8.TabIndex = 15;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_0
            // 
            this.button_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_0.FlatAppearance.BorderSize = 0;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_0.Location = new System.Drawing.Point(323, 53);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(74, 44);
            this.button_0.TabIndex = 14;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_9
            // 
            this.button_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_9.FlatAppearance.BorderSize = 0;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_9.Location = new System.Drawing.Point(243, 53);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(74, 44);
            this.button_9.TabIndex = 12;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_5
            // 
            this.button_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_5.FlatAppearance.BorderSize = 0;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_5.Location = new System.Drawing.Point(323, 3);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(74, 44);
            this.button_5.TabIndex = 4;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_4.Location = new System.Drawing.Point(243, 3);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(74, 44);
            this.button_4.TabIndex = 3;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_3
            // 
            this.button_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_3.Location = new System.Drawing.Point(163, 3);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(74, 44);
            this.button_3.TabIndex = 2;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_2.Location = new System.Drawing.Point(83, 3);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(74, 44);
            this.button_2.TabIndex = 1;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_1.Location = new System.Drawing.Point(3, 3);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(74, 44);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_Backspace
            // 
            this.button_Backspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Backspace.FlatAppearance.BorderSize = 0;
            this.button_Backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Backspace.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Backspace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Backspace.Location = new System.Drawing.Point(403, 3);
            this.button_Backspace.Name = "button_Backspace";
            this.button_Backspace.Size = new System.Drawing.Size(74, 44);
            this.button_Backspace.TabIndex = 11;
            this.button_Backspace.Text = "🢦";
            this.button_Backspace.UseVisualStyleBackColor = true;
            this.button_Backspace.Click += new System.EventHandler(this.button_Backspace_Click);
            // 
            // button1_Dot
            // 
            this.button1_Dot.FlatAppearance.BorderSize = 0;
            this.button1_Dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Dot.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Dot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1_Dot.Location = new System.Drawing.Point(483, 3);
            this.button1_Dot.Name = "button1_Dot";
            this.button1_Dot.Size = new System.Drawing.Size(75, 44);
            this.button1_Dot.TabIndex = 18;
            this.button1_Dot.Text = ".";
            this.button1_Dot.UseVisualStyleBackColor = true;
            this.button1_Dot.Click += new System.EventHandler(this.button1_Dot_Click);
            this.button1_Dot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_Dot_KeyPress);
            // 
            // Speed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(959, 622);
            this.Controls.Add(this.tableLayoutPanel_Keyboard);
            this.Controls.Add(this.button_KeyboardMenu);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.textBox_ToUnit);
            this.Controls.Add(this.textBox_FromUnit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Convert);
            this.Controls.Add(this.label_ToUnit);
            this.Controls.Add(this.label_FromUnit);
            this.Controls.Add(this.comboBox_FromUnit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_ToUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Speed";
            this.Text = "Speed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.tableLayoutPanel_Keyboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button button_KeyboardMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Keyboard;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_Backspace;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Button button1_Dot;
        protected System.Windows.Forms.ComboBox comboBox_FromUnit;
        protected System.Windows.Forms.Button button_Convert;
        protected System.Windows.Forms.ComboBox comboBox_ToUnit;
        protected System.Windows.Forms.TextBox textBox_FromUnit;
        protected System.Windows.Forms.TextBox textBox_ToUnit;
        protected System.Windows.Forms.Label label_FromUnit;
        protected System.Windows.Forms.Label label_ToUnit;
    }
}