using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MenuStrip
{
    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(52, 152, 219); // Blue Accent
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(52, 152, 219);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(52, 152, 219);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(41, 128, 185);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(41, 128, 185);
        public override Color MenuItemBorder => Color.Transparent;
        
        public override Color ToolStripDropDownBackground => Color.FromArgb(30, 30, 30);
        public override Color ImageMarginGradientBegin => Color.FromArgb(30, 30, 30);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(30, 30, 30);
        public override Color ImageMarginGradientEnd => Color.FromArgb(30, 30, 30);
        
        public override Color MenuBorder => Color.FromArgb(50, 50, 50);
        public override Color SeparatorDark => Color.FromArgb(60, 60, 60);
    }

    public class CustomRenderer : ToolStripProfessionalRenderer
    {
        public CustomRenderer() : base(new CustomColorTable()) { }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                var rect = new Rectangle(Point.Empty, e.Item.Size);
                using (var brush = new SolidBrush(Color.FromArgb(52, 152, 219)))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }
}
