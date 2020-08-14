using Forms.UnitConverter;
using System;
using System.Windows.Forms;
using Unit.Converter;

namespace Engineers_Helper.Forms.UnitConverter
{
    public partial class Pressure : Speed
    {
        public Pressure()
        {
            InitializeComponent();
        }
        

        protected override void SetComboBox()
        {
            comboBox_FromUnit.DataSource = Enum.GetValues(typeof(PressureConverter.PressureUnit));
            comboBox_ToUnit.DataSource = Enum.GetValues(typeof(PressureConverter.PressureUnit));
        }

        protected override void Calculate()
        {
            if (textBox_FromUnit.Text != string.Empty)
            {
               
                var pressureConverter = new PressureConverter(decimal.Parse(textBox_FromUnit.Text), comboBox_FromUnit.Text, comboBox_ToUnit.Text);
                textBox_ToUnit.Text = pressureConverter.ConvertUnit().ToString(".######");
            }

        }
    }
}
