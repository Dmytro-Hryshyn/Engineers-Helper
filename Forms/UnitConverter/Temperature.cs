using Forms.UnitConverter;
using System;
using Unit.Converter;

namespace Engineers_Helper.Forms
{
    public partial class Temperature : Speed
    {
        public Temperature()
        {
            InitializeComponent();
        }

        protected override void Calculate()
        {
            if (textBox_FromUnit.Text != string.Empty)
            {

                TemperatureConverter temperatureConverter = new TemperatureConverter(decimal.Parse(textBox_FromUnit.Text),
                                                                           comboBox_FromUnit.Text, comboBox_ToUnit.Text);

                textBox_ToUnit.Text = temperatureConverter.ConvertUnit().ToString(".######");
            }
        }


        protected override void SetComboBox()
        {
            comboBox_FromUnit.DataSource = Enum.GetValues(typeof(TemperatureConverter.TemperatureUnit));
            comboBox_ToUnit.DataSource = Enum.GetValues(typeof(TemperatureConverter.TemperatureUnit));
        }
    }
}



