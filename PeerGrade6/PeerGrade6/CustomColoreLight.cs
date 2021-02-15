using System.Drawing;
using System.Windows.Forms;

namespace PeerGrade6
{
    // Перкраска меню под выбранный фон.
    public class CustomColoreLight : ProfessionalColorTable
    {
        public override Color MenuItemSelected => SystemColors.ControlDark;
        public override Color MenuBorder => SystemColors.ControlDark;
        public override Color MenuItemBorder => SystemColors.ControlDark;
        public override Color ToolStripBorder => SystemColors.ControlDark;
        public override Color ToolStripDropDownBackground => SystemColors.ControlDark;
        public override Color ToolStripGradientBegin => SystemColors.ControlDark;
        public override Color ToolStripGradientEnd => SystemColors.ControlDark;
        public override Color ToolStripGradientMiddle => SystemColors.ControlDark;
        public override Color MenuItemPressedGradientBegin => SystemColors.ControlDark;
        public override Color MenuItemPressedGradientEnd => SystemColors.ControlDark;
        public override Color MenuItemPressedGradientMiddle => SystemColors.ControlDark;
        public override Color MenuItemSelectedGradientBegin => SystemColors.ControlDark;
        public override Color MenuItemSelectedGradientEnd => SystemColors.ControlDark;
    }
}