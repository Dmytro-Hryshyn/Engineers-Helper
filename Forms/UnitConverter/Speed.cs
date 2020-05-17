using ModernUiDesign;
using System;
using System.Windows.Forms;

namespace Forms.UnitConverter
{


    public partial class Speed : Form
    {
        public Speed()
        {
            InitializeComponent();
            SetComboBox();
            tableLayoutPanel_Keyboard.Visible = false;
        }
  

        protected virtual void  DisplayError(string errorMess)
        {
            MessageBox.Show(errorMess,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            label_ToUnit.Visible = false;
        }

        private void comboBox_ToUnit_Click(object sender, EventArgs e)
        {
            label_FromUnit.Visible = false;
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

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text += "9";
        }

        private void button1_Dot_Click(object sender, EventArgs e)
        {
            if (textBox_FromUnit.Text.Contains("."))
            {
                return;
            }


            else textBox_FromUnit.Text += ".";
        }

        private void button_Backspace_Click(object sender, EventArgs e)
        {
            if (textBox_FromUnit.Text.Length > 1)
            {
                textBox_FromUnit.Text = textBox_FromUnit.Text.Remove(textBox_FromUnit.Text.Length - 2, 1);
            }

            else textBox_FromUnit.Text = string.Empty;
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text = string.Empty;
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Dot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && !textBox_FromUnit.Text.Contains("."))
            {
                textBox_FromUnit.Text += ".";
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_FromUnit.Text = string.Empty;
            textBox_ToUnit.Text = string.Empty;
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        protected virtual void Calculate()
        {
            if (textBox_FromUnit.Text != string.Empty)
            {
                SpeedConverter speedConverter = new SpeedConverter(decimal.Parse(textBox_FromUnit.Text), comboBox_FromUnit.Text.Replace(" ", "_"), comboBox_ToUnit.Text.Replace(" ", "_"));
                textBox_ToUnit.Text = speedConverter.GetUnswer();
            }
             if (textBox_ToUnit.Text=="0.error")
            {
                textBox_ToUnit.Text = string.Empty;
                DisplayError("Error, try select enother speed unit");
            }
            else return;
        }

        private void textBox_FromUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        protected virtual void SetComboBox()
        {
            var speedDictinary = SpeedConverter.NiceComboboxDataRepresentation();
            comboBox_FromUnit.DataSource = new BindingSource(speedDictinary, null);
            comboBox_FromUnit.DisplayMember = "Key";
            comboBox_FromUnit.ValueMember = "Value";

            comboBox_ToUnit.DataSource = new BindingSource(speedDictinary, null);
            comboBox_ToUnit.DisplayMember = "Key";
            comboBox_ToUnit.ValueMember = "Value";
        }
    }
}
