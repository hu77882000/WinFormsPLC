using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WinFormsPLC
{
    public partial class FrmAddIPEquipment : DockContent
    {
        public FrmAddIPEquipment()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();//关闭当前界面
            MessageBox.Show(cmbComm.Text);
        }

        private void cmbComm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbComm.SelectedIndex==0)
            {

            }
            else if (cmbComm.SelectedIndex==1)
            {

            }
            else
            {
                MessageBox.Show("xxxxxxxxxxxxxxxxxxxxxxx");
            }
        }

        private void FrmAddIPEquipment_Load(object sender, EventArgs e)
        {
            uiCheckBoxGroup2.Visible = true;
            uiCheckBoxGroup1.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
