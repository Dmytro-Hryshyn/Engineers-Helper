using Forms.UnitConverter;
using Unit.Converter;
using System;

namespace Engineers_Helper.Forms.UnitConverter
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
                textBox_ToUnit.Text = angleConverter.ConvertUnit().ToString(".#####");
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
