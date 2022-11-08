using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace AppModelo.View.Windows.Helpers
{
    public class LimparTela
    {
        public void LimparCampos(ControlCollection controls)
        {
            foreach (TextBox tb in controls.OfType<TextBox>())
                tb.Text = string.Empty;
            foreach (Control c in controls)
                LimparCampos(c.Controls);
            
            foreach (MaskedTextBox mb in controls.OfType<MaskedTextBox>())
                mb.Text = string.Empty;
            foreach (Control c in controls)
                LimparCampos(c.Controls);

            foreach (ComboBox cb in controls.OfType<ComboBox>())
                cb.Text = string.Empty;
            foreach (Control c in controls)
                LimparCampos(c.Controls);
        }
    }
}
