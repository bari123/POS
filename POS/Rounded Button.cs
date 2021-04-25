using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace POS
{
   public class Rounded_Button : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
             GraphicsPath grPath  = new GraphicsPath();
            grPath.AddEllipse(1, 1, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
