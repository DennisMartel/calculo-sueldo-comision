using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tulen_Dennis
{
    class Limpiar
    {
        public void Borrar(Control c, GroupBox gb)
        {
            foreach (var txt in c.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
                else if (txt is RadioButton) 
                    ((RadioButton)txt).Checked = false;
            }

            foreach (var grp in gb.Controls)
            {
                if (grp is TextBox)
                    ((TextBox)grp).Clear();
                else if (grp is RadioButton)
                    ((RadioButton)grp).Checked = false;
            }
        }
    }
}
