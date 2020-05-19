using Forms.UnitConverter;
using ModernUiDesign.Controls.Converter;
using System;

namespace ModernUiDesign.Forms.UnitConverter
{
    public partial class Angle : Speed
    {
        public Angle()
        {
            InitializeComponent();

        }

        protected override void Calculate()

        {
            if (textBox_FromUnit.Text != string.Empty)
            {
                AngleConverter angleConverter = new AngleConverter(decimal.Parse(textBox_FromUnit.Text), comboBox_FromUnit.Text, comboBox_ToUnit.Text);
                textBox_ToUnit.Text = angleConverter.GetUnswer();
            }

           
            if (textBox_ToUnit.Text == "0.error")
            {
                textBox_ToUnit.Text = string.Empty;
                DisplayError("Error, try select enother angle unit");
            }

            else return;
        }

        protected override void SetComboBox()
        {
            comboBox_FromUnit.DataSource = Enum.GetValues(typeof(AngleConverter.AngleUnit));
            comboBox_ToUnit.DataSource = Enum.GetValues(typeof(AngleConverter.AngleUnit));
        }


    }

}
