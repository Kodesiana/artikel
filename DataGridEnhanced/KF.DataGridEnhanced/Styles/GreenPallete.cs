using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KF.DataGridEnhanced.Styles
{
    public class GreenPallete : StylePallete
    {
        public GreenPallete()
        {
            var font = new Font("Segoe UI", 9.87F, FontStyle.Regular, GraphicsUnit.Point, 0);

            // global style
            Font = font;
            BackColor = Color.Black;
            ForeColor = Color.White;
            RowHeight = 25;
            HeaderHeight = 60;

            // column header
            HeaderStyle = new DataGridViewCellStyle
            {
                Font = font,
                ForeColor = Color.White,
                BackColor = Color.Black,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            // cell style
            CellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Gray,
                SelectionBackColor = Color.FromArgb(35, 168, 109),
                SelectionForeColor = Color.White
            };

            // alternating cell style
            AlternatingRowCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.SlateGray
            };
        }
    }
}
