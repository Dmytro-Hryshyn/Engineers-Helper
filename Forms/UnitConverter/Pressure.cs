using Forms.UnitConverter;
using ModernUiDesign.Controls.Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUiDesign.Forms.UnitConverter
{
    public partial class Pressure : Speed
    {
        public Pressure()
        {
            InitializeComponent();
        }
        string errorTodisplay = "Error, try select enother pressure unit";

        protected override void SetComboBox()
        {
            comboBox_FromUnit.DataSource = Enum.GetValues(typeof(PressureConverter.PressureUnit));
            comboBox_ToUnit.DataSource = Enum.GetValues(typeof(PressureConverter.PressureUnit));
        }

      
        protected override void DisplayError(string errorText)
        {
            MessageBox.Show(errorTodisplay,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        protected override void Calculate()
        {
            if (textBox_FromUnit.Text != string.Empty)
            {
                ErrorCall error = this.DisplayError;
                var pressureConverter = new PressureConverter(decimal.Parse(textBox_FromUnit.Text), comboBox_FromUnit.Text, comboBox_ToUnit.Text);
                textBox_ToUnit.Text = pressureConverter.GetUnswer(error, errorTodisplay).ToString("#.##########");
            }
           
        }
    }
}
