using System.Linq;
using System.Windows.Forms;
using Geometry;
using Geometry.Rectangle;

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

            textBox_Angle_a.MouseEnter += (s, a) => pictureBox1.Image = Properties.Resources.RectangleAngleA;
            textBox_Angle_a.MouseLeave += (s, a) => DefaultIamage();

            textBox_Angle_b.MouseEnter += (s, a) => pictureBox1.Image = Properties.Resources.RectangleAngleB;
            textBox_Angle_b.MouseLeave += (s, a) => DefaultIamage();

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
            RectanleSolver solver = new RectanleSolver();
            solver.SideA = textBox_Side_a.Text != string.Empty ? double.Parse(textBox_Side_a.Text) : 0;
            solver.SideB = textBox_Side_b.Text != string.Empty? double.Parse(textBox_Side_b.Text):0;
            solver.Diagonal = textBox_Diagonal.Text != string.Empty? double.Parse(textBox_Diagonal.Text):0;
            solver.Perimeter = textBox_Perimeter.Text != string.Empty? double.Parse(textBox_Perimeter.Text):0;
            solver.Area = textBox_Area.Text != string.Empty? double.Parse(textBox_Area.Text):0;
            solver.CircumscribedRadius = textBox_Circumradius.Text != string.Empty ? double.Parse(textBox_Circumradius.Text) : 0;
            solver.AngleA= textBox_Angle_a.Text != string.Empty ? double.Parse(textBox_Angle_a.Text) : 0;
            solver.AngleB= textBox_Angle_b.Text != string.Empty ? double.Parse(textBox_Angle_b.Text) : 0;
            solver.Solve();
            textBox_Side_a.Text = solver.SideA.ToString("#.####");
            textBox_Side_b.Text = solver.SideB.ToString("#.####");
            textBox_Diagonal.Text=solver.Diagonal.ToString("#.####");
            textBox_Perimeter.Text = solver.Perimeter.ToString("#.####");
            textBox_Area.Text = solver.Area.ToString("#.####");
            textBox_Circumradius.Text = solver.CircumscribedRadius.ToString("#.####");
            textBox_Angle_a.Text = solver.AngleA.ToString("#.####");
            textBox_Angle_b.Text = solver.AngleB.ToString("#.####");
        }

        private void Button_Clear_Click(object sender, System.EventArgs e)
        {
            foreach (var  item in panel_TextBoxes.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text = string.Empty;
                }
            }
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
