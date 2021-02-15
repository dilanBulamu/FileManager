using System.Windows.Forms;

namespace PeerGrade6
{
    public class Renderer: ToolStripProfessionalRenderer
    {
        public Renderer(CustomColoreDark tmp) : base(tmp) { }
        public Renderer(CustomColoreLight tmp) : base(tmp) { }
    }
}
