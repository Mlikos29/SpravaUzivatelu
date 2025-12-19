using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpravaUzivatelu
{
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
            Change_Password_Box.Visible = false;
        }

        private void View_Profile_Button_Click(object sender, EventArgs e)
        {

        }

        private void Change_Password_Button_Click(object sender, EventArgs e)
        {
            if (Change_Password_Box.Visible == false)
            {
                Change_Password_Box.Visible = true;
            }
            else if (Change_Password_Box.Visible == true)
            {
                Change_Password_Box.Visible = false;
            }
        }
    }
}
