﻿using Forms.UnitConverter;
using ModernUiDesign.Controls;
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
            SubMenuContol referenceSubControl = new SubMenuContol(ReferenceMenu_Btn, ReferenceSubmenu_Panel);
        }
    }
}

