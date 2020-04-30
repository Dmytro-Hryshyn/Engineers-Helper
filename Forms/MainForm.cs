using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.UnitConverter;
using ModernUiDesign.Controls;

namespace ModernUiDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
            
            SubMenuContol unitConverterSubcontol = new SubMenuContol(UnitConverter_Menu_Btn,UnitConverter_Submenu_Panel);
            Speed_Converter_Btn.Click += (sender, EventArgs) => unitConverterSubcontol.OpenChildForm(new Speed(), ChildForm_Panel);
            SubMenuContol referenceSubControl = new SubMenuContol(ReferenceMenu_Btn, ReferenceSubmenu_Panel);


        }

    }
}

