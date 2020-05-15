using Forms.UnitConverter;
using System;
using System.Windows.Forms;

namespace ModernUiDesign
{
    

    public partial class Length : Speed
    {
        
        public Length()
        {
            InitializeComponent();
            SetComboBox();
        }
        

        private static void DisplayError(string textError)
        {
            MessageBox.Show(textError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 

        protected override void SetComboBox()
        {
           
            comboBox_FromUnit.DataSource = Enum.GetValues(typeof(LengthConverter.LengthUnits));
            comboBox_ToUnit.DataSource = Enum.GetValues(typeof(LengthConverter.LengthUnits));
            comboBox_FromUnit.SelectedIndex = 0;
            comboBox_ToUnit.SelectedIndex = 1;
        }

        private   void button_Convert_Click(object sender, EventArgs e)
        {
            Calculate();
            
        }

        protected override void Calculate()
        {
            if (textBox_FromUnit.Text==string.Empty)
            {
                return;
            }
            
           else if (textBox_ToUnit.Text=="0.error")
            {
                textBox_ToUnit.Text = string.Empty;
                DisplayError("Eror. Try to select another unit");
            }

            else
            {
                LengthConverter lenthConverter = new LengthConverter(decimal.Parse(textBox_FromUnit.Text),
                                                                comboBox_FromUnit.SelectedItem.ToString(),
                                                                    comboBox_ToUnit.SelectedItem.ToString());
                textBox_ToUnit.Text = lenthConverter.GetUnswer();
            }
        }

       
    }
}
