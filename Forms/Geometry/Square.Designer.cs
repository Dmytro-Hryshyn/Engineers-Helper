namespace ModernUiDesign.Forms.Geometry
{
    partial class Square
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Square));
            this.Btn_Back = new System.Windows.Forms.Button();
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
            this.Btn_Back.Size = new System.Drawing.Size(50, 600);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Square";
            this.Text = "Square";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
    }
}