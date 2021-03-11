using Engineers_Helper.Controls;
using Engineers_Helper.Forms;
using Engineers_Helper.Forms.Geometry;
using Engineers_Helper.Forms.UnitConverter;
using Forms.UnitConverter;
using System.Windows.Forms;

namespace Engineers_Helper
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

            #region Geometry2D menu
            SubMenuContol geometrySubMenu = new SubMenuContol(Geometry2DMenu_Btn, GeometrySubMenu_Panel);
            Square_btn.Click += (s, a) =>
            {
                geometrySubMenu.OpenChildForm(new SquareForm(), ChildForm_Panel);
                MenuPanel.Visible = false;
            };
            Rectangle_Btn.Click += (s, a) =>
            {
                geometrySubMenu.OpenChildForm(new RectangleForm(), ChildForm_Panel);
                MenuPanel.Visible = false;
            };
            #endregion
        }
    }
}

