using System.Windows.Forms;

namespace Engineers_Helper.Forms.Geometry
{
    public partial class RectangleForm : Form
    {
        public RectangleForm()
        {
            InitializeComponent();

            textBox_Side_a.MouseEnter += (s, a) => pictureBox1.Image = Properties.Resources.RectangleSideA;
            textBox_Side_a.MouseLeave += (s, a) => DefaultIamage();

            textBox_Side_b.MouseEnter += (s, a) => pictureBox1.Image = Properties.Resources.RectangleSideB;
            textBox_Side_b.MouseLeave += (s, a) => DefaultIamage();

            textBox_Diagonal.MouseEnter += (s, a) => pictureBox1.Image = Properties.Resources.RectangleDiagonal;
            textBox_Diagonal.MouseLeave += (s, a) => DefaultIamage();

            textBox_Perimeter.MouseEnter += (s, a) => pictureBox1.Image = Properties.Resources.RectanglePerimeter;
            textBox_Perimeter.MouseLeave += (s, a) => DefaultIamage();

            textBox_Area.MouseEnter += (s, a) => pictureBox1.Image = Properties.Resources.RectangleArea;
            textBox_Area.MouseLeave += (s, a) => DefaultIamage();

            textBox_Circumradius.MouseEnter += (s, a) => pictureBox1.Image = Properties.Resources.RectangleOutRadius;
            textBox_Circumradius.MouseLeave += (s, a) => DefaultIamage();

        }


        private void DefaultIamage()
        {
            pictureBox1.Image = Properties.Resources.RectangleBase;
        }

        private void Btn_Back_Click(object sender, System.EventArgs e)
        {
            this.Close();
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

        private void lable_Difinition_Click(object sender, System.EventArgs e)
        {
            richTextBox_Definition.Visible = !richTextBox_Definition.Visible;
        }


        private void lable_Properties_Click(object sender, System.EventArgs e)
        {
            richTextBox_Properties.Visible = !richTextBox_Properties.Visible;
        }

        private void lable_SidesFormulas_Click(object sender, System.EventArgs e)
        {
            richTextBox_SidesFormulas.Visible = !richTextBox_SidesFormulas.Visible;
        }


        private void lable_DiagonalFormulas_Click(object sender, System.EventArgs e)
        {
            richTextBox_DiagonalFormula.Visible = !richTextBox_DiagonalFormula.Visible;
        }


        private void lable_PerimeterFormulas_Click(object sender, System.EventArgs e)
        {
            richTextBox_PerimeterFormulas.Visible = !richTextBox_PerimeterFormulas.Visible;
        }

        private void lable_AreaFormulas_Click(object sender, System.EventArgs e)
        {
            richbox_AreaFormulas.Visible = !richbox_AreaFormulas.Visible;
        }

        private void lable_CircumradiusFormulas_Click(object sender, System.EventArgs e)
        {
            richTextBox_CircumscribedradiusFormula.Visible = !richTextBox_CircumscribedradiusFormula.Visible;
        }

        private void lable_AngleFormulas_Click(object sender, System.EventArgs e)
        {
            richTextBox_AngleFormulas.Visible = !richTextBox_AngleFormulas.Visible;
        }

    }
}
