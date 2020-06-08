using ModernUiDesign.Controls.Geometry;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ModernUiDesign.Forms.Geometry
{

    public partial class SquareForm : Form
    {
        public SquareForm()
        {
            InitializeComponent();
            #region Textboxes Events
            textBox_Side.MouseEnter += (s, a) => AnimatePictureBox("Side.png");
            textBox_Side.MouseLeave += (s, a) => AnimatePictureBox("Square.png");
            textBox_IsideRadius.MouseEnter += (s, a) => AnimatePictureBox("Inside Radius.png");
            textBox_IsideRadius.MouseLeave += (s, a) => AnimatePictureBox("Square.png");
            textBox_OutsideRadius.MouseEnter += (s, a) => AnimatePictureBox("Outside Radius.png");
            textBox_OutsideRadius.MouseLeave += (s, a) => AnimatePictureBox("Square.png");
            textBox_Diagonal.MouseEnter += (s, a) => AnimatePictureBox("Diagonals.png");
            textBox_Diagonal.MouseLeave += (s, a) => AnimatePictureBox("Square.png");
            textBox_Area.MouseEnter += (s, a) => AnimatePictureBox("Area.png");
            textBox_Area.MouseLeave += (s, a) => AnimatePictureBox("Square.png");
            textBox_Perimeter.MouseEnter += (s, a) => AnimatePictureBox("Perimeter.png");
            textBox_Perimeter.MouseLeave += (s, a) => AnimatePictureBox("Square.png");


            void AnimatePictureBox(string pictureName)
            {
                pictureBox_Screan.Image = Image.FromFile(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Resource\Square\" + pictureName);
            }
            #endregion  
        }


        private void Btn_Back_Click(object sender, EventArgs e)
        {

            this.Close();
            Form1.ActiveForm.Controls["MenuPanel"].Visible = true;
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            panel_Info.Visible = (panel_Info.Visible == false) ? true : false;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            foreach (TextBox control in Controls.OfType<TextBox>())
            {
                control.Text = string.Empty;
            }
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            
            #region initialize
           

            #endregion
        }
    }
}
