using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsPLC_Net40.Model;

namespace WinFormsPLC_Net40.Steps
{
    public partial class FrmStepNew : Form
    {
        public FrmStepNew(string frm)
        {
            InitializeComponent();
        }
      private  string uuid = Guid.NewGuid().ToString();
        private string dataNow = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss fff");
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                PtNewinstructions pnew = new PtNewinstructions();
                pnew.Itemcode = this.txtNo.Text.Trim();
                pnew.Itemname = this.txtname.Text.Trim();
                pnew.Performcontent = this.txtContent.Text.Trim();
                pnew.Performreturn = this.txtReturn.Text.Trim();
                string sqlstr = string.Format("insert into PT_NewInstructions values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}','{9}','{10}')", uuid, pnew.Itemcode, pnew.Itemname, "管理员", dataNow, "", dataNow, 0, pnew.Itemname, pnew.Performcontent, pnew.Performreturn);
                bool i = SqliteHelper.OperationDB(sqlstr);
                if (i)
                {
                    MessageBox.Show("新增成功");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("添加失败！ 错误原因："+ex.Message);
            }
            
        }
    }
}
