using System.Drawing;
using System.Windows.Forms;

namespace PeerGrade6
{
    // Перкраска меню под выбранный фон.
    public class CustomColoreDark : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(20, 20, 21);
        public override Color MenuBorder => Color.FromArgb(20, 20, 21);
        public override Color MenuItemBorder => Color.FromArgb(20, 20, 21);
        public override Color ToolStripBorder => Color.FromArgb(20, 20, 21);
        public override Color ToolStripDropDownBackground => Color.FromArgb(20, 20, 21);
        public override Color ToolStripGradientBegin => Color.FromArgb(20, 20, 21);
        public override Color ToolStripGradientEnd => Color.FromArgb(20, 20, 21);
        public override Color ToolStripGradientMiddle => Color.FromArgb(20, 20, 21);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(20, 20, 21);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(20, 20, 21);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(20, 20, 21);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(48, 48, 49);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(48, 48, 49);
    }
}
