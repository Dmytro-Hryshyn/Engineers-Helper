using Forms.UnitConverter;
using Unit.Converter;
using System.Windows.Forms;

namespace ModernUiDesign.Forms.UnitConverter
{
    public partial class WeightAndMass : Speed
    {
        public string ErrorText { get; } = "Error, try select enother weight unit";

        public WeightAndMass()
        {
            InitializeComponent();
            
        }

        
        protected override void Calculate()
        {
            ErrorCall call = DisplayError;
            if (textBox_FromUnit.Text!=string.Empty)
            {
                WeightAndMassConverter weightAndMassConverter = new WeightAndMassConverter(decimal.Parse(textBox_FromUnit.Text), comboBox_FromUnit.Text, comboBox_ToUnit.Text);
                textBox_ToUnit.Text = weightAndMassConverter.GetUnswer(call, ErrorText).ToString("0.##########");
               
            }
            
        }
        protected override void SetComboBox()
        {

            comboBox_FromUnit.DataSource = new BindingSource(WeightAndMassConverter.NiceComboboxData(), null);
            comboBox_FromUnit.DisplayMember = "Key";
            comboBox_FromUnit.ValueMember = "Value";

            comboBox_ToUnit.DataSource = new BindingSource(WeightAndMassConverter.NiceComboboxData(), null);
            comboBox_ToUnit.DisplayMember = "Key";
            comboBox_ToUnit.ValueMember = "Value";

        }

        protected override void DisplayError(string ErrorText)
        {
            base.DisplayError(this.ErrorText);
        }
    }
}
