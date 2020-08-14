using Forms.UnitConverter;
using System.Windows.Forms;
using Unit.Converter;

namespace Engineers_Helper.Forms.UnitConverter
{
    public partial class WeightAndMass : Speed
    {
        public WeightAndMass()
        {
            InitializeComponent();
        }

        protected override void Calculate()
        {
            if (textBox_FromUnit.Text != string.Empty)
            {
                WeightAndMassConverter weightAndMassConverter = new WeightAndMassConverter(decimal.Parse(textBox_FromUnit.Text), comboBox_FromUnit.Text, comboBox_ToUnit.Text);
                textBox_ToUnit.Text = weightAndMassConverter.ConvertUnit().ToString("0.##########");
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
    }
}
