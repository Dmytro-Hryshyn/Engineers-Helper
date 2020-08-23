using Geometry.Square;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Engineers_Helper.Forms.Geometry
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
                pictureBox_Screan.Image = Image.FromFile(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + @"\Resource\Square\" + pictureName);
            }
            #endregion
            #region Textbox lost focuse event

          
            textBox_Side.LostFocus += (s, a) => { foreach (var control in Controls.OfType<TextBox>())
                {
                    control.ReadOnly = true;
                } };

            textBox_Diagonal.LostFocus += (s, a) => 
            {
                foreach (var item in Controls.OfType<TextBox>())
                {
                    item.ReadOnly = true;
                }
            };

            textBox_Perimeter.LostFocus += (s, a) => 
            {
                foreach (var item in Controls.OfType<TextBox>())
                {
                    item.ReadOnly = true;
                }
            };
            textBox_Area.LostFocus += (s, a) =>
            {
                foreach (var item in Controls.OfType<TextBox>())
                {
                    item.ReadOnly = true;
                }
            };
            textBox_IsideRadius.LostFocus += (s, a) =>
            {
                foreach (var item in Controls.OfType<TextBox>())
                {
                    item.ReadOnly = true;
                }
            };
            textBox_OutsideRadius.LostFocus += (s, a) =>
            {
                foreach (var item in Controls.OfType<TextBox>())
                {
                    item.ReadOnly = true;
                }
            };
            #endregion
            CorrectinputForTexBoxes();
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
                control.ReadOnly = false;
            }
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {

            double side = textBox_Side.Text != string.Empty ? double.Parse(textBox_Side.Text) : 0;
            double diagonal = textBox_Diagonal.Text != string.Empty ? double.Parse(textBox_Diagonal.Text) : 0;
            double perimeter = textBox_Perimeter.Text != string.Empty ? double.Parse(textBox_Perimeter.Text) : 0;
            double area = textBox_Area.Text != string.Empty ? double.Parse(textBox_Area.Text) : 0;
            double ourRad = textBox_OutsideRadius.Text != string.Empty ? double.Parse(textBox_OutsideRadius.Text) : 0;
            double inRad = textBox_IsideRadius.Text != string.Empty ? double.Parse(textBox_IsideRadius.Text) : 0;
            SquareSolver square = new SquareSolver(side, diagonal, perimeter, area, ourRad, inRad);
            square.GetAllValuesOfSquare();
            textBox_Side.Text = square.Side.ToString("0.###");
            textBox_Diagonal.Text = square.Diagonal.ToString("0.###");
            textBox_Perimeter.Text = square.Perimeter.ToString("0.###");
            textBox_Area.Text = square.Area.ToString("0.###");
            textBox_OutsideRadius.Text = square.CircumScribedRadius.ToString("0.###");
            textBox_IsideRadius.Text = square.InRadius.ToString("0.###");
            SetTexboxToReadOnly();


        }


        /// <summary>
        /// Set all textboxes on current form to read only.
        /// </summary>
        void SetTexboxToReadOnly()
        {
            foreach (TextBox control in Controls.OfType<TextBox>())
            {
                control.ReadOnly = true;
            }
        }

        /// <summary>
        /// Allows enter only numbers and one decimal point for all textboxes which contains on curent form.
        /// </summary>
        void CorrectinputForTexBoxes()
        {
            foreach (TextBox item in Controls.OfType<TextBox>())
            {
                item.KeyPress += (object sender, KeyPressEventArgs e) =>
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                    {
                        e.Handled = true;
                    }
                };
            }
        }

        private void label_Definition_Click(object sender, EventArgs e)
        {
            richTextBox_Definition.Visible = (richTextBox_Definition.Visible == false) ? true : false;
        }

        private void label_Properties_Click(object sender, EventArgs e)
        {
            richTextBox_Properties.Visible = (richTextBox_Properties.Visible == false) ? true : false;
        }

        private void label_DiagonalFormula_Click(object sender, EventArgs e)
        {
            richTextBox_DiagonalFormula.Visible=(richTextBox_DiagonalFormula.Visible == false) ? true : false;
        }

        //Simple way. Shorter then ternary operator or If else ;))
        private void label_PerimeterFormula_Click(object sender, EventArgs e)
        {
            richTextBox_PerimeterFormula.Visible = !richTextBox_PerimeterFormula.Visible;
        }

        private void label_AreaFormula_Click(object sender, EventArgs e)
        {
            richTextBox_AreaFormula.Visible = !richTextBox_AreaFormula.Visible;
        }

        private void label_CircumradiusFormula_Click(object sender, EventArgs e)
        {
            richTextBox_CircumradiusFormula.Visible = !richTextBox_CircumradiusFormula.Visible;
        }

        private void label_InradiusFormula_Click(object sender, EventArgs e)
        {
            richTextBox_InradiusFormula.Visible = !richTextBox_InradiusFormula.Visible;
        }
    }
}
