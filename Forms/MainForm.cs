using Forms.UnitConverter;
using ModernUiDesign.Controls;
using System.Windows.Forms;

namespace ModernUiDesign
{


    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            SubMenuContol unitConverterSubcontol = new SubMenuContol(UnitConverter_Menu_Btn, UnitConverter_Submenu_Panel);
            Speed_Converter_Btn.Click += (sender, EventArgs) =>
            {
                unitConverterSubcontol.OpenChildForm(new Speed(), ChildForm_Panel);
                MenuPanel.Visible = false;
            };
            SubMenuContol referenceSubControl = new SubMenuContol(ReferenceMenu_Btn, ReferenceSubmenu_Panel);
        }
    }
}

