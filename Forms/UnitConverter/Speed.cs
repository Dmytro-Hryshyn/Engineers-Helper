using ModernUiDesign;
using System;
using System.Windows.Forms;
using ModernUiDesign.Controls;
using System.Collections.Generic;
namespace Forms.UnitConverter
{


    public partial class Speed : Form
    {

        public Speed()
        {
            InitializeComponent();
        }

        
       
        
        

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            //sets visibiliti of Menu panel on MainForm
             Form1.ActiveForm.Controls["MenuPanel"].Visible = true;

        }
    }
}
