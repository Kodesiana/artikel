using System.Drawing;
using System.Windows.Forms;

namespace KF.DataGridEnhanced.Styles
{
    public class StylePallete
    {
        public Font Font { get; set; }
        public int HeaderHeight { get; set; }
        public int RowHeight { get; set; }

        // color pallete
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }

        // alternate color
        public DataGridViewCellStyle HeaderStyle { get; set; }
        public DataGridViewCellStyle CellStyle { get; set; }
        public DataGridViewCellStyle AlternatingRowCellStyle { get; set; }
    }
}
