using System.Windows.Forms;

namespace Engineers_Helper.Forms.Geometry
{
    public partial class RectangleForm : Form
    {
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, System.EventArgs e)
        {
            Form1.ActiveForm.Controls["MenuPanel"].Visible = true;
        }

        private void Button_Info_Click(object sender, System.EventArgs e)
        {
            panel_Info.Visible = !panel_Info.Visible;
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox_Angle_b_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox_Angle_a_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox_Diagonal_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox_Side_b_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox_Side_a_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void Button_Solve_Click(object sender, System.EventArgs e)
        {

        }

        private void Button_Clear_Click(object sender, System.EventArgs e)
        {

        }
    }
}
