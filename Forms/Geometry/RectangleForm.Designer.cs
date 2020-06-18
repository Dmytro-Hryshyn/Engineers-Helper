namespace Engineers_Helper.Forms.Geometry
{
    partial class RectangleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectangleForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.lable_Info = new System.Windows.Forms.Label();
            this.panel_Image = new System.Windows.Forms.Panel();
            this.panel_TextBoxes = new System.Windows.Forms.Panel();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Solve = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Circumradius = new System.Windows.Forms.Label();
            this.textBox_Angle_b = new System.Windows.Forms.TextBox();
            this.label_Angle_b = new System.Windows.Forms.Label();
            this.textBox_Angle_a = new System.Windows.Forms.TextBox();
            this.label_Angle_a = new System.Windows.Forms.Label();
            this.textBox_Diagonal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Side_b = new System.Windows.Forms.TextBox();
            this.label_Side_b = new System.Windows.Forms.Label();
            this.textBox_Side_a = new System.Windows.Forms.TextBox();
            this.label_Side_a = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Info.SuspendLayout();
            this.panel_Image.SuspendLayout();
            this.panel_TextBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.MaximumSize = new System.Drawing.Size(58, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 761);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // button_Info
            // 
            this.button_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Info.FlatAppearance.BorderSize = 0;
            this.button_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Info.Image = ((System.Drawing.Image)(resources.GetObject("button_Info.Image")));
            this.button_Info.Location = new System.Drawing.Point(1326, 0);
            this.button_Info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Info.MaximumSize = new System.Drawing.Size(58, 0);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(58, 761);
            this.button_Info.TabIndex = 0;
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.Button_Info_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.lable_Info);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Info.Location = new System.Drawing.Point(1016, 0);
            this.panel_Info.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel_Info.Size = new System.Drawing.Size(310, 761);
            this.panel_Info.TabIndex = 1;
            this.panel_Info.Visible = false;
            // 
            // lable_Info
            // 
            this.lable_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.lable_Info.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_Info.ForeColor = System.Drawing.SystemColors.Window;
            this.lable_Info.Location = new System.Drawing.Point(0, 10);
            this.lable_Info.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.lable_Info.Name = "lable_Info";
            this.lable_Info.Size = new System.Drawing.Size(310, 46);
            this.lable_Info.TabIndex = 0;
            this.lable_Info.Text = "Info";
            this.lable_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Image
            // 
            this.panel_Image.Controls.Add(this.panel_TextBoxes);
            this.panel_Image.Controls.Add(this.pictureBox1);
            this.panel_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Image.Location = new System.Drawing.Point(58, 0);
            this.panel_Image.Name = "panel_Image";
            this.panel_Image.Size = new System.Drawing.Size(958, 761);
            this.panel_Image.TabIndex = 2;
            // 
            // panel_TextBoxes
            // 
            this.panel_TextBoxes.Controls.Add(this.button_Clear);
            this.panel_TextBoxes.Controls.Add(this.button_Solve);
            this.panel_TextBoxes.Controls.Add(this.textBox1);
            this.panel_TextBoxes.Controls.Add(this.label_Circumradius);
            this.panel_TextBoxes.Controls.Add(this.textBox_Angle_b);
            this.panel_TextBoxes.Controls.Add(this.label_Angle_b);
            this.panel_TextBoxes.Controls.Add(this.textBox_Angle_a);
            this.panel_TextBoxes.Controls.Add(this.label_Angle_a);
            this.panel_TextBoxes.Controls.Add(this.textBox_Diagonal);
            this.panel_TextBoxes.Controls.Add(this.label1);
            this.panel_TextBoxes.Controls.Add(this.textBox_Side_b);
            this.panel_TextBoxes.Controls.Add(this.label_Side_b);
            this.panel_TextBoxes.Controls.Add(this.textBox_Side_a);
            this.panel_TextBoxes.Controls.Add(this.label_Side_a);
            this.panel_TextBoxes.Location = new System.Drawing.Point(423, 0);
            this.panel_TextBoxes.Margin = new System.Windows.Forms.Padding(3, 150, 3, 3);
            this.panel_TextBoxes.Name = "panel_TextBoxes";
            this.panel_TextBoxes.Size = new System.Drawing.Size(535, 761);
            this.panel_TextBoxes.TabIndex = 1;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Clear.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Clear.Location = new System.Drawing.Point(268, 516);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(181, 56);
            this.button_Clear.TabIndex = 0;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // button_Solve
            // 
            this.button_Solve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_Solve.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Solve.FlatAppearance.BorderSize = 0;
            this.button_Solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Solve.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Solve.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Solve.Location = new System.Drawing.Point(85, 516);
            this.button_Solve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Solve.Name = "button_Solve";
            this.button_Solve.Size = new System.Drawing.Size(181, 56);
            this.button_Solve.TabIndex = 0;
            this.button_Solve.Text = "Solve";
            this.button_Solve.UseVisualStyleBackColor = false;
            this.button_Solve.Click += new System.EventHandler(this.Button_Solve_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(168, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 33);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_Circumradius
            // 
            this.label_Circumradius.AutoSize = true;
            this.label_Circumradius.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Circumradius.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Circumradius.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Circumradius.Location = new System.Drawing.Point(14, 447);
            this.label_Circumradius.Margin = new System.Windows.Forms.Padding(3);
            this.label_Circumradius.Name = "label_Circumradius";
            this.label_Circumradius.Size = new System.Drawing.Size(143, 18);
            this.label_Circumradius.TabIndex = 1;
            this.label_Circumradius.Text = "Circumradius - R";
            this.label_Circumradius.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Angle_b
            // 
            this.textBox_Angle_b.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Angle_b.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Angle_b.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Angle_b.Location = new System.Drawing.Point(168, 382);
            this.textBox_Angle_b.Name = "textBox_Angle_b";
            this.textBox_Angle_b.Size = new System.Drawing.Size(292, 33);
            this.textBox_Angle_b.TabIndex = 2;
            this.textBox_Angle_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Angle_b.TextChanged += new System.EventHandler(this.textBox_Angle_b_TextChanged);
            // 
            // label_Angle_b
            // 
            this.label_Angle_b.AutoSize = true;
            this.label_Angle_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Angle_b.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Angle_b.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Angle_b.Location = new System.Drawing.Point(74, 391);
            this.label_Angle_b.Margin = new System.Windows.Forms.Padding(3);
            this.label_Angle_b.Name = "label_Angle_b";
            this.label_Angle_b.Size = new System.Drawing.Size(83, 18);
            this.label_Angle_b.TabIndex = 1;
            this.label_Angle_b.Text = "Angle - β";
            this.label_Angle_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Angle_a
            // 
            this.textBox_Angle_a.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Angle_a.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Angle_a.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Angle_a.Location = new System.Drawing.Point(168, 327);
            this.textBox_Angle_a.Name = "textBox_Angle_a";
            this.textBox_Angle_a.Size = new System.Drawing.Size(292, 33);
            this.textBox_Angle_a.TabIndex = 2;
            this.textBox_Angle_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Angle_a.TextChanged += new System.EventHandler(this.textBox_Angle_a_TextChanged);
            // 
            // label_Angle_a
            // 
            this.label_Angle_a.AutoSize = true;
            this.label_Angle_a.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Angle_a.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Angle_a.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Angle_a.Location = new System.Drawing.Point(74, 335);
            this.label_Angle_a.Margin = new System.Windows.Forms.Padding(3);
            this.label_Angle_a.Name = "label_Angle_a";
            this.label_Angle_a.Size = new System.Drawing.Size(83, 18);
            this.label_Angle_a.TabIndex = 1;
            this.label_Angle_a.Text = "Angle - α";
            this.label_Angle_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Diagonal
            // 
            this.textBox_Diagonal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Diagonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Diagonal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Diagonal.Location = new System.Drawing.Point(168, 272);
            this.textBox_Diagonal.Name = "textBox_Diagonal";
            this.textBox_Diagonal.Size = new System.Drawing.Size(292, 33);
            this.textBox_Diagonal.TabIndex = 2;
            this.textBox_Diagonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Diagonal.TextChanged += new System.EventHandler(this.textBox_Diagonal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(43, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doagonal - d";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Side_b
            // 
            this.textBox_Side_b.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Side_b.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Side_b.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Side_b.Location = new System.Drawing.Point(168, 217);
            this.textBox_Side_b.Name = "textBox_Side_b";
            this.textBox_Side_b.Size = new System.Drawing.Size(292, 33);
            this.textBox_Side_b.TabIndex = 2;
            this.textBox_Side_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Side_b.TextChanged += new System.EventHandler(this.textBox_Side_b_TextChanged);
            // 
            // label_Side_b
            // 
            this.label_Side_b.AutoSize = true;
            this.label_Side_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Side_b.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Side_b.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Side_b.Location = new System.Drawing.Point(85, 223);
            this.label_Side_b.Margin = new System.Windows.Forms.Padding(3);
            this.label_Side_b.Name = "label_Side_b";
            this.label_Side_b.Size = new System.Drawing.Size(72, 18);
            this.label_Side_b.TabIndex = 1;
            this.label_Side_b.Text = "Side - b";
            this.label_Side_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Side_a
            // 
            this.textBox_Side_a.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Side_a.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Side_a.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Side_a.Location = new System.Drawing.Point(168, 162);
            this.textBox_Side_a.Name = "textBox_Side_a";
            this.textBox_Side_a.Size = new System.Drawing.Size(292, 33);
            this.textBox_Side_a.TabIndex = 2;
            this.textBox_Side_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Side_a.TextChanged += new System.EventHandler(this.textBox_Side_a_TextChanged);
            // 
            // label_Side_a
            // 
            this.label_Side_a.AutoSize = true;
            this.label_Side_a.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Side_a.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Side_a.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Side_a.Location = new System.Drawing.Point(85, 167);
            this.label_Side_a.Margin = new System.Windows.Forms.Padding(3);
            this.label_Side_a.Name = "label_Side_a";
            this.label_Side_a.Size = new System.Drawing.Size(72, 18);
            this.label_Side_a.TabIndex = 1;
            this.label_Side_a.Text = "Side - a";
            this.label_Side_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(108, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.panel_Image);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RectangleForm";
            this.Text = "Rectangle";
            this.panel_Info.ResumeLayout(false);
            this.panel_Image.ResumeLayout(false);
            this.panel_TextBoxes.ResumeLayout(false);
            this.panel_TextBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label lable_Info;
        private System.Windows.Forms.Panel panel_Image;
        private System.Windows.Forms.Panel panel_TextBoxes;
        private System.Windows.Forms.TextBox textBox_Side_a;
        private System.Windows.Forms.Label label_Side_a;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Side_b;
        private System.Windows.Forms.Label label_Side_b;
        private System.Windows.Forms.TextBox textBox_Diagonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Circumradius;
        private System.Windows.Forms.TextBox textBox_Angle_b;
        private System.Windows.Forms.Label label_Angle_b;
        private System.Windows.Forms.TextBox textBox_Angle_a;
        private System.Windows.Forms.Label label_Angle_a;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Solve;
    }
}