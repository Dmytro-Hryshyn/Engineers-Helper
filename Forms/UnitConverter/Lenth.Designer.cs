namespace ModernUiDesign
{
    partial class Lenth
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
            this.SuspendLayout();
            // 
            // button_Convert
            // 
            this.button_Convert.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Convert.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // textBox_FromUnit
            // 
            this.textBox_FromUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "Millemter"});
            // 
            // Lenth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(959, 622);
            this.Name = "Lenth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
