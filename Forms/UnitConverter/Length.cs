using Forms.UnitConverter;
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


            var lengthDictinary = LengthConverter.NiceComboboxDataRepresentation();
            comboBox_FromUnit.DataSource = new BindingSource(lengthDictinary, null);
            comboBox_FromUnit.DisplayMember = "Key";
            comboBox_FromUnit.ValueMember = "Value";

            comboBox_ToUnit.DataSource = new BindingSource(lengthDictinary, null);
            comboBox_ToUnit.DisplayMember = "Key";
            comboBox_ToUnit.ValueMember = "Value";
        }



        protected override void Calculate()
        {
            if (textBox_FromUnit.Text != string.Empty)
            {
                LengthConverter lenthConverter = new LengthConverter(decimal.Parse(textBox_FromUnit.Text),
                                                                comboBox_FromUnit.Text.Replace(" ", "_"),
                                                                    comboBox_ToUnit.Text.Replace(" ", "_"));
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
