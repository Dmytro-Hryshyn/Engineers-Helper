using System;
using System.Windows.Forms;

namespace ModernUiDesign
{
    

    public partial class Lenth : Forms.UnitConverter.Speed
    {
        
        public Lenth()
        {
            InitializeComponent();
            SetComboBoxes();
        }
        

        private static void DisplayError(string textError)
        {
            MessageBox.Show(textError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } //ErrorHendler

        private void SetComboBoxes()
        {
           
            comboBox_FromUnit.DataSource = Enum.GetValues(typeof(LenthConverter.LenthUnits));
            comboBox_ToUnit.DataSource = Enum.GetValues(typeof(LenthConverter.LenthUnits));
            comboBox_FromUnit.SelectedIndex = 0;
            comboBox_ToUnit.SelectedIndex = 1;
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            LenthConverter lenthConverter = new LenthConverter(decimal.Parse(textBox_FromUnit.Text),
                                                                comboBox_FromUnit.SelectedItem.ToString(),
                                                                    comboBox_ToUnit.SelectedItem.ToString());
            textBox_ToUnit.Text = lenthConverter.GetUnswer();
        }

    }
}
