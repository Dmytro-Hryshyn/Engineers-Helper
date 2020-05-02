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
            this.comboBox_ToUnit = new System.Windows.Forms.ComboBox();
            this.label_FromUnit = new System.Windows.Forms.Label();
            this.label_ToUnit = new System.Windows.Forms.Label();
            this.button_Convert = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
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
            this.comboBox_FromUnit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_FromUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FromUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_FromUnit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FromUnit.FormattingEnabled = true;
            this.comboBox_FromUnit.Location = new System.Drawing.Point(239, 268);
            this.comboBox_FromUnit.Name = "comboBox_FromUnit";
            this.comboBox_FromUnit.Size = new System.Drawing.Size(150, 33);
            this.comboBox_FromUnit.TabIndex = 1;
            // 
            // comboBox_ToUnit
            // 
            this.comboBox_ToUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_ToUnit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_ToUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ToUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_ToUnit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ToUnit.FormattingEnabled = true;
            this.comboBox_ToUnit.Items.AddRange(new object[] {
            "Mile",
            "Kilometre",
            "Metre",
            "Feet",
            "Inch",
            "Santimetre",
            "Millimetre"});
            this.comboBox_ToUnit.Location = new System.Drawing.Point(662, 268);
            this.comboBox_ToUnit.Name = "comboBox_ToUnit";
            this.comboBox_ToUnit.Size = new System.Drawing.Size(150, 33);
            this.comboBox_ToUnit.TabIndex = 2;
            // 
            // label_FromUnit
            // 
            this.label_FromUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FromUnit.AutoSize = true;
            this.label_FromUnit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FromUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_FromUnit.Location = new System.Drawing.Point(262, 238);
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
            this.label_ToUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ToUnit.Location = new System.Drawing.Point(698, 238);
            this.label_ToUnit.Name = "label_ToUnit";
            this.label_ToUnit.Size = new System.Drawing.Size(78, 23);
            this.label_ToUnit.TabIndex = 4;
            this.label_ToUnit.Text = "To Unit";
            // 
            // button_Convert
            // 
            this.button_Convert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Convert.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Convert.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Convert.Location = new System.Drawing.Point(392, 392);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(141, 57);
            this.button_Convert.TabIndex = 5;
            this.button_Convert.Text = "C&onvert";
            this.button_Convert.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Clear.Location = new System.Drawing.Point(539, 392);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(141, 57);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "&Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // Speed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1045, 643);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Convert);
            this.Controls.Add(this.label_ToUnit);
            this.Controls.Add(this.label_FromUnit);
            this.Controls.Add(this.comboBox_ToUnit);
            this.Controls.Add(this.comboBox_FromUnit);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Speed";
            this.Text = "Speed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_FromUnit;
        private System.Windows.Forms.ComboBox comboBox_ToUnit;
        private System.Windows.Forms.Label label_FromUnit;
        private System.Windows.Forms.Label label_ToUnit;
        private System.Windows.Forms.Button button_Convert;
        private System.Windows.Forms.Button button_Clear;
    }
}