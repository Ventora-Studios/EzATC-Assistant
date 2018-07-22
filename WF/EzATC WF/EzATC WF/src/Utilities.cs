using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace EzATC_WF.src
{
    class Utilities
    {

        //<summary> Klasse, die uns einzelne Funktionen ermöglicht. Z.b. konvertieren von Formaten
        //oder auch die Transparenz
        //</summary>

        public static void makeLabelTransparent(Form f, Label l, PictureBox pbox)
        {
            var pos = f.PointToScreen(l.Location);
            pos = pbox.PointToClient(pos);
            l.Parent = pbox;
            l.Location = pos;
            l.BackColor = Color.Transparent;
        }

    }
}
