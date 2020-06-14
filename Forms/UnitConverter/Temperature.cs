using Forms.UnitConverter;
using Unit.Converter;
using System;
using System.Windows.Forms;

namespace ModernUiDesign.Forms
{
    public partial class Temperature : Speed
    {
        public Temperature()
        {
            InitializeComponent();

        }

        protected override void Calculate()
        {
            string errorMessage = "Try select enother temperature unit";

            if (textBox_FromUnit.Text != string.Empty)
            {
                ErrorCall errorcall = DisplayError;
                TemperatureConverter temperatureConverter = new TemperatureConverter(decimal.Parse(textBox_FromUnit.Text),
                                                                           comboBox_FromUnit.Text, comboBox_ToUnit.Text);
                
                textBox_ToUnit.Text = temperatureConverter.GetUnswer(errorcall, errorMessage);
            }


        }


        protected override void SetComboBox()
        {
            comboBox_FromUnit.DataSource = Enum.GetValues(typeof(TemperatureConverter.TemperatureUnit));
            comboBox_ToUnit.DataSource = Enum.GetValues(typeof(TemperatureConverter.TemperatureUnit));
        }

        protected override void DisplayError(string Errormessage)
        {
            System.Windows.Forms.MessageBox.Show(Errormessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}



