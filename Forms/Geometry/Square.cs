using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ModernUiDesign.Forms.Geometry
{
    public partial class Square : Form
    {
        public Square()
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


    }
}
