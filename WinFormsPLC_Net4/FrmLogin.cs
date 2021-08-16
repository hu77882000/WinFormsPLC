using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPLC_Net4
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtname.Text.Trim()!="" && this.txtpwd.Text.Trim() != "") {
                FrmSelect frmSelect = new FrmSelect(txtname.Text);
                frmSelect.ShowDialog();
            }
            
        }
    }
}
