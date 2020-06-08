namespace ModernUiDesign.Forms.Geometry
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.Btn_Back.MaximumSize = new System.Drawing.Size(50, 0);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(50, 700);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // pictureBox_Screan
            // 
            this.pictureBox_Screan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Screan.Image")));
            this.pictureBox_Screan.Location = new System.Drawing.Point(79, 118);
            this.pictureBox_Screan.Name = "pictureBox_Screan";
            this.pictureBox_Screan.Size = new System.Drawing.Size(332, 305);
            this.pictureBox_Screan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Screan.TabIndex = 1;
            this.pictureBox_Screan.TabStop = false;
            // 
            // textBox_Side
            // 
            this.textBox_Side.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Side.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Side.Location = new System.Drawing.Point(499, 132);
            this.textBox_Side.Name = "textBox_Side";
            this.textBox_Side.Size = new System.Drawing.Size(212, 40);
            this.textBox_Side.TabIndex = 3;
            this.textBox_Side.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Side
            // 
            this.label_Side.AutoSize = true;
            this.label_Side.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Side.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Side.Location = new System.Drawing.Point(496, 106);
            this.label_Side.Name = "label_Side";
            this.label_Side.Size = new System.Drawing.Size(61, 16);
            this.label_Side.TabIndex = 4;
            this.label_Side.Text = "Side - a";
            // 
            // label_Perimeter
            // 
            this.label_Perimeter.AutoSize = true;
            this.label_Perimeter.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Perimeter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Perimeter.Location = new System.Drawing.Point(496, 182);
            this.label_Perimeter.Name = "label_Perimeter";
            this.label_Perimeter.Size = new System.Drawing.Size(95, 16);
            this.label_Perimeter.TabIndex = 6;
            this.label_Perimeter.Text = "Perimeter - P";
            // 
            // textBox_Perimeter
            // 
            this.textBox_Perimeter.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Perimeter.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Perimeter.Location = new System.Drawing.Point(499, 208);
            this.textBox_Perimeter.Name = "textBox_Perimeter";
            this.textBox_Perimeter.Size = new System.Drawing.Size(212, 40);
            this.textBox_Perimeter.TabIndex = 5;
            this.textBox_Perimeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Area
            // 
            this.label_Area.AutoSize = true;
            this.label_Area.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Area.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Area.Location = new System.Drawing.Point(496, 334);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(64, 16);
            this.label_Area.TabIndex = 8;
            this.label_Area.Text = "Area - A";
            // 
            // textBox_Area
            // 
            this.textBox_Area.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Area.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Area.Location = new System.Drawing.Point(499, 360);
            this.textBox_Area.Name = "textBox_Area";
            this.textBox_Area.Size = new System.Drawing.Size(212, 40);
            this.textBox_Area.TabIndex = 7;
            this.textBox_Area.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Header
            // 
            this.Label_Header.AutoSize = true;
            this.Label_Header.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Header.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Header.Location = new System.Drawing.Point(492, 26);
            this.Label_Header.Name = "Label_Header";
            this.Label_Header.Size = new System.Drawing.Size(143, 42);
            this.Label_Header.TabIndex = 9;
            this.Label_Header.Text = "Square";
            // 
            // button_Clear
            // 
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Clear.Location = new System.Drawing.Point(472, 608);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(110, 45);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Calculate
            // 
            this.button_Calculate.FlatAppearance.BorderSize = 0;
            this.button_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calculate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Calculate.Location = new System.Drawing.Point(601, 608);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(110, 45);
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
            this.button_Info.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button_Info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Info.Image = ((System.Drawing.Image)(resources.GetObject("button_Info.Image")));
            this.button_Info.Location = new System.Drawing.Point(1150, 0);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(50, 700);
            this.button_Info.TabIndex = 12;
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.label1);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Info.Location = new System.Drawing.Point(900, 0);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(250, 700);
            this.panel_Info.TabIndex = 13;
            this.panel_Info.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Info";
            // 
            // label_InsideRadius
            // 
            this.label_InsideRadius.AutoSize = true;
            this.label_InsideRadius.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InsideRadius.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_InsideRadius.Location = new System.Drawing.Point(496, 410);
            this.label_InsideRadius.Name = "label_InsideRadius";
            this.label_InsideRadius.Size = new System.Drawing.Size(116, 16);
            this.label_InsideRadius.TabIndex = 15;
            this.label_InsideRadius.Text = "Inside Radius - r";
            // 
            // textBox_IsideRadius
            // 
            this.textBox_IsideRadius.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_IsideRadius.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IsideRadius.Location = new System.Drawing.Point(499, 436);
            this.textBox_IsideRadius.Name = "textBox_IsideRadius";
            this.textBox_IsideRadius.Size = new System.Drawing.Size(212, 40);
            this.textBox_IsideRadius.TabIndex = 14;
            this.textBox_IsideRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(496, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Outside Radius - R";
            // 
            // textBox_OutsideRadius
            // 
            this.textBox_OutsideRadius.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_OutsideRadius.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OutsideRadius.Location = new System.Drawing.Point(499, 512);
            this.textBox_OutsideRadius.Name = "textBox_OutsideRadius";
            this.textBox_OutsideRadius.Size = new System.Drawing.Size(212, 40);
            this.textBox_OutsideRadius.TabIndex = 16;
            this.textBox_OutsideRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Diagonal
            // 
            this.label_Diagonal.AutoSize = true;
            this.label_Diagonal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Diagonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Diagonal.Location = new System.Drawing.Point(496, 258);
            this.label_Diagonal.Name = "label_Diagonal";
            this.label_Diagonal.Size = new System.Drawing.Size(88, 16);
            this.label_Diagonal.TabIndex = 19;
            this.label_Diagonal.Text = "Diagonal - d";
            // 
            // textBox_Diagonal
            // 
            this.textBox_Diagonal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Diagonal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Diagonal.Location = new System.Drawing.Point(499, 284);
            this.textBox_Diagonal.Name = "textBox_Diagonal";
            this.textBox_Diagonal.Size = new System.Drawing.Size(212, 40);
            this.textBox_Diagonal.TabIndex = 18;
            this.textBox_Diagonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.label_Diagonal);
            this.Controls.Add(this.textBox_Diagonal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_OutsideRadius);
            this.Controls.Add(this.label_InsideRadius);
            this.Controls.Add(this.textBox_IsideRadius);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.Label_Header);
            this.Controls.Add(this.label_Area);
            this.Controls.Add(this.textBox_Area);
            this.Controls.Add(this.label_Perimeter);
            this.Controls.Add(this.textBox_Perimeter);
            this.Controls.Add(this.label_Side);
            this.Controls.Add(this.textBox_Side);
            this.Controls.Add(this.pictureBox_Screan);
            this.Controls.Add(this.Btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Square";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_InsideRadius;
        private System.Windows.Forms.TextBox textBox_IsideRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_OutsideRadius;
        private System.Windows.Forms.Label label_Diagonal;
        private System.Windows.Forms.TextBox textBox_Diagonal;
    }
}