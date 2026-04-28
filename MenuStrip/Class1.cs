using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MenuStrip
{
    internal class Class1
    {
        class CustomColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(70, 70, 70); }
            }

            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(70, 70, 70); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return Color.FromArgb(45, 45, 48); }
            }

            public override Color MenuBorder
            {
                get { return Color.FromArgb(45, 45, 48); }
            }
        }
    }
}
