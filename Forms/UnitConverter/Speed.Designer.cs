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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_KeyboardMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Keyboard = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
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
            this.button1.Size = new System.Drawing.Size(50, 643);
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
            this.comboBox_FromUnit.FormattingEnabled = true;
            this.comboBox_FromUnit.Location = new System.Drawing.Point(275, 256);
            this.comboBox_FromUnit.Name = "comboBox_FromUnit";
            this.comboBox_FromUnit.Size = new System.Drawing.Size(150, 33);
            this.comboBox_FromUnit.TabIndex = 1;
            this.comboBox_FromUnit.Click += new System.EventHandler(this.comboBox_FromUnit_Click);
            // 
            // label_FromUnit
            // 
            this.label_FromUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FromUnit.AutoSize = true;
            this.label_FromUnit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FromUnit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_FromUnit.Location = new System.Drawing.Point(298, 168);
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
            this.label_ToUnit.Location = new System.Drawing.Point(724, 168);
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
            this.button_Convert.Location = new System.Drawing.Point(407, 389);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(141, 50);
            this.button_Convert.TabIndex = 5;
            this.button_Convert.Text = "C&onvert";
            this.button_Convert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Convert.UseVisualStyleBackColor = true;
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
            this.button_Clear.Location = new System.Drawing.Point(554, 389);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_Clear.Size = new System.Drawing.Size(141, 50);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "&Clear";
            this.button_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Clear.UseVisualStyleBackColor = false;
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
            this.comboBox_ToUnit.FormattingEnabled = true;
            this.comboBox_ToUnit.Location = new System.Drawing.Point(688, 256);
            this.comboBox_ToUnit.Name = "comboBox_ToUnit";
            this.comboBox_ToUnit.Size = new System.Drawing.Size(150, 33);
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
            this.textBox_FromUnit.Location = new System.Drawing.Point(275, 203);
            this.textBox_FromUnit.MaxLength = 15;
            this.textBox_FromUnit.Name = "textBox_FromUnit";
            this.textBox_FromUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_FromUnit.Size = new System.Drawing.Size(150, 33);
            this.textBox_FromUnit.TabIndex = 8;
            this.textBox_FromUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(688, 203);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(150, 33);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(495, 203);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(117, 72);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 10;
            this.pictureBox_Logo.TabStop = false;
            // 
            // button_KeyboardMenu
            // 
            this.button_KeyboardMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_KeyboardMenu.FlatAppearance.BorderSize = 0;
            this.button_KeyboardMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KeyboardMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_KeyboardMenu.Image = ((System.Drawing.Image)(resources.GetObject("button_KeyboardMenu.Image")));
            this.button_KeyboardMenu.Location = new System.Drawing.Point(50, 593);
            this.button_KeyboardMenu.Name = "button_KeyboardMenu";
            this.button_KeyboardMenu.Size = new System.Drawing.Size(995, 50);
            this.button_KeyboardMenu.TabIndex = 11;
            this.button_KeyboardMenu.UseVisualStyleBackColor = true;
            this.button_KeyboardMenu.Click += new System.EventHandler(this.button_KeyboardMenu_Click);
            // 
            // tableLayoutPanel_Keyboard
            // 
            this.tableLayoutPanel_Keyboard.AllowDrop = true;
            this.tableLayoutPanel_Keyboard.ColumnCount = 6;
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Keyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button12, 0, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button11, 4, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button10, 3, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button6, 4, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button5, 3, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel_Keyboard.Controls.Add(this.button13, 5, 0);
            this.tableLayoutPanel_Keyboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel_Keyboard.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_Keyboard.Location = new System.Drawing.Point(50, 493);
            this.tableLayoutPanel_Keyboard.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.tableLayoutPanel_Keyboard.Name = "tableLayoutPanel_Keyboard";
            this.tableLayoutPanel_Keyboard.RowCount = 2;
            this.tableLayoutPanel_Keyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Keyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Keyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Keyboard.Size = new System.Drawing.Size(995, 100);
            this.tableLayoutPanel_Keyboard.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(168, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(333, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(498, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 44);
            this.button5.TabIndex = 3;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(663, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 44);
            this.button6.TabIndex = 4;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(168, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 44);
            this.button7.TabIndex = 5;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(333, 53);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(159, 44);
            this.button8.TabIndex = 6;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(498, 53);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 44);
            this.button9.TabIndex = 7;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(663, 53);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(159, 44);
            this.button10.TabIndex = 8;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(828, 53);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(164, 44);
            this.button11.TabIndex = 9;
            this.button11.Text = "CE";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.Location = new System.Drawing.Point(3, 53);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(159, 44);
            this.button12.TabIndex = 10;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(828, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(164, 44);
            this.button13.TabIndex = 11;
            this.button13.Text = "🢦";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // Speed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1045, 643);
            this.Controls.Add(this.tableLayoutPanel_Keyboard);
            this.Controls.Add(this.button_KeyboardMenu);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.ComboBox comboBox_FromUnit;
        private System.Windows.Forms.Label label_FromUnit;
        private System.Windows.Forms.Label label_ToUnit;
        private System.Windows.Forms.Button button_Convert;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ComboBox comboBox_ToUnit;
        private System.Windows.Forms.TextBox textBox_FromUnit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button button_KeyboardMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Keyboard;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}