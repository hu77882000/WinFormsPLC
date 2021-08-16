using System;
using System.Windows.Forms;

namespace WinFormsPLC_Net40.Steps
{
    public partial class FrmStep : Form
    {
        public FrmStep()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmStepNew frm = new FrmStepNew("");
            frm.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmStepNew frm = new FrmStepNew("当前选择的行号 -1");
            frm.Show();
        }


        private void uiDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in uiDataGridView1.Rows)
            {
                row.Cells[0].Value = row.Index + 1;
            }
        }

        private void uiDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
