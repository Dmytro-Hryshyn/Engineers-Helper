using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUiDesign.Forms.Geometry
{
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
           
        }


        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.ActiveForm.Controls["MenuPanel"].Visible = true;
        }
    }
}
