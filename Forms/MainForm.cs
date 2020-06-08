using Forms.UnitConverter;
using ModernUiDesign.Controls;
using ModernUiDesign.Forms;
using ModernUiDesign.Forms.Geometry;
using ModernUiDesign.Forms.UnitConverter;
using System;
using System.Windows.Forms;

namespace ModernUiDesign
{


    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            #region UnitConverter menu

          
            SubMenuContol unitConverterSubcontol = new SubMenuContol(UnitConverter_Menu_Btn, UnitConverter_Submenu_Panel);
            Speed_Converter_Btn.Click += (sender, EventArgs) =>
            {
                unitConverterSubcontol.OpenChildForm(new Speed(), ChildForm_Panel);
                MenuPanel.Visible = false;
            };

            Length_Converter_Btn.Click += (s, a) =>
            {
                unitConverterSubcontol.OpenChildForm(new Length(), ChildForm_Panel);
                MenuPanel.Visible = false;
            };
            Angle_Converter_Btn.Click += (s, a) =>
              {
                  unitConverterSubcontol.OpenChildForm(new Angle(), ChildForm_Panel);
                  MenuPanel.Visible = false;
              };
            Temperature_Converter_Btn.Click += (s, a) =>
            {
                unitConverterSubcontol.OpenChildForm(new Temperature(), ChildForm_Panel);
                MenuPanel.Visible = false;
            };
            Pressure_Converter_Btn.Click += (s, a) =>
            {
                unitConverterSubcontol.OpenChildForm(new Pressure(), ChildForm_Panel);
                MenuPanel.Visible = false;
            };
            WaightAndMass_Button.Click += (s, a) =>
              {
                  unitConverterSubcontol.OpenChildForm(new WeightAndMass(), ChildForm_Panel);
                  MenuPanel.Visible = false;
              };
            #endregion

            #region  Reference menu

            SubMenuContol referenceSubControl = new SubMenuContol(ReferenceMenu_Btn, ReferenceSubmenu_Panel);
            #endregion

            #region Geometry2D menu
            SubMenuContol geometrySubMenu = new SubMenuContol(Geometry2DMenu_Btn, GeometrySubMenu_Panel);
            Square_btn.Click += (s, a) => 
            {
                geometrySubMenu.OpenChildForm(new SquareForm(), ChildForm_Panel);
                MenuPanel.Visible = false;
            };
            #endregion
        }

       
    }
}

