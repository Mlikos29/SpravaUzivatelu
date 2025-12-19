using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpravaUzivatelu.Services
{
    public static class FormHelper
    {
        public static void OpenForm(Form current, Form next)
        {
            current.Hide();
            next.FormClosed += (s, args) => current.Close();
            next.Show();
        }
    }
}
