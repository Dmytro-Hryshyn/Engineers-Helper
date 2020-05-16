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
        

       

        protected override void SetComboBox()
        {
           
            comboBox_FromUnit.DataSource = Enum.GetValues(typeof(LengthConverter.LengthUnits));
            comboBox_ToUnit.DataSource = Enum.GetValues(typeof(LengthConverter.LengthUnits));
            comboBox_FromUnit.SelectedIndex = 0;
            comboBox_ToUnit.SelectedIndex = 1;
        }

      

        protected override void Calculate()
        {
            if (textBox_FromUnit.Text != string.Empty)
            {
                LengthConverter lenthConverter = new LengthConverter(decimal.Parse(textBox_FromUnit.Text),
                                                                comboBox_FromUnit.Text,
                                                                    comboBox_ToUnit.Text);
                textBox_ToUnit.Text = lenthConverter.GetUnswer();
            }

            if (textBox_ToUnit.Text == "0.error")
            {
                textBox_ToUnit.Text = string.Empty;

                DisplayError("Error, try select enother lenght unit");

            }

            else return;
            
        }

      
    }
}
