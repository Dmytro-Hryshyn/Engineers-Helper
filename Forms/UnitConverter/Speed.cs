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
            tableLayoutPanel_Keyboard.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            //sets visibiliti of Menu panel on MainForm
             Form1.ActiveForm.Controls["MenuPanel"].Visible = true;

        }

        private void comboBox_FromUnit_Click(object sender, EventArgs e)
        {
            label_FromUnit.Visible = false;
        }

        private void comboBox_ToUnit_Click(object sender, EventArgs e)
        {
            label_ToUnit.Visible = false;
        }

        private void button_KeyboardMenu_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel_Keyboard.Visible == true)
            {
                tableLayoutPanel_Keyboard.Visible = false;
            }
            else
            {
            tableLayoutPanel_Keyboard.Visible = true;
            }
        }
    }
}
