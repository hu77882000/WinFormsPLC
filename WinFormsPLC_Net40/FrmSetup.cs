using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading;
using System.Windows.Forms;
using WinFormsPLC_Net40.GlobalClass;
using WinFormsPLC_Net40.Model;

namespace WinFormsPLC_Net40
{
    public partial class FrmSetup : Form
    {
        private SQLiteConnection conn = null;
        private SQLiteDataAdapter da = null;
        SQLiteCommand command = null;
        DataSet ds = new DataSet();
        private  static string id ="0";
        Equipment_Directive equipment_Directive = new Equipment_Directive();
        private  string sql_select = "select ItemCode,ItemName ItemName,PerformName,PerformContent,PerformReturn,PerformOrder,PerformEnable from Equipment_Directive where isdelete =0  and DeviceType= '" + id+"'";
        public FrmSetup()
        {
            InitializeComponent();
            //错误委托
            this.uiDataGridView1.DataError += delegate (object sender, DataGridViewDataErrorEventArgs e) { };
        }

        private void FrmSetup_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.ViewEquipment_Perform”中。您可以根据需要移动或删除它。
            //this.viewEquipment_PerformTableAdapter.Fill(this.dataSet1.ViewEquipment_Perform);
            this.BtnDelConfig.Enabled = false;
            this.BtnNewConfig.Enabled = false;
            this.BtnUpdateConfig.Enabled = false;
            this.uiTextBox1.Text = PlcEntity.SerialNumber;
            BindDataGridView();
            id =(string) SqliteHelper.ExecuteScalar("select id from PT_Term where ItemCode='"+ PlcEntity.SerialNumber + "' ",null);
        }
        private void BindDataGridView()
        {
            ////读取数据库
            conn = new SQLiteConnection(SqliteHelper.connStr/* ConfigurationSettings.AppSettings["connstr"]*/);
            conn.Open();
            command = new SQLiteCommand(sql_select, conn);
            da = new SQLiteDataAdapter(command);
            da.Fill(ds, "Equipment_Directive");
            this.uiDataGridView1.DataSource = ds.Tables[0];
            uiDataGridView1.Columns["ItemCode"].HeaderText = "编号";
            uiDataGridView1.Columns["ItemName"].HeaderText = "设备名称";
            uiDataGridView1.Columns["PerformName"].HeaderText = "指令类型";
            uiDataGridView1.Columns["PerformContent"].HeaderText = "执行内容";
            uiDataGridView1.Columns["PerformReturn"].HeaderText = "返回结果";
            uiDataGridView1.Columns["PerformOrder"].HeaderText = "执行顺序";
            uiDataGridView1.Columns["PerformEnable"].HeaderText = "启用";


        }
        #region  按钮事件未启用

        private void BtnNewConfig_Click(object sender, EventArgs e)
        {
            //新增一行
            /*
                        DataRow dr = ds.Tables[0].NewRow();
                        ds.Tables[0].Rows.Add(dr);
                        uiDataGridView1.DataSource = ds.Tables[0];*/
            DataTable dt = new DataTable();
            DataRow dr = dt.NewRow();
            uiDataGridView1.DataSource = dt;
        }

        private void BtnDelConfig_Click(object sender, EventArgs e)
        {
            //删除前确认
            /*            if (MessageBox.Show("确认要删除选中的行吗?", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.uiDataGridView1.Rows.Remove(this.uiDataGridView1.SelectedRows[0]);
                        }*/

            //读取数据库
            ds.AcceptChanges();
            SQLiteCommandBuilder scb = new SQLiteCommandBuilder(da);
            ds.Tables[0].Rows[this.uiDataGridView1.CurrentRow.Index].Delete();
            da.DeleteCommand = scb.GetDeleteCommand();
            da.Update(ds, "Equipment_Directive");
        }

        private void BtnUpdateConfig_Click(object sender, EventArgs e)
        {
            //读取数据库
            SQLiteCommandBuilder scb = new SQLiteCommandBuilder(da);
            da.UpdateCommand = scb.GetUpdateCommand();
            da.Update(ds, "Equipment_Directive");
        }

        #endregion
        private void uiDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (uiDataGridView1.Rows.Count > 0)
            {
                equipment_Directive.ItemCode = this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                equipment_Directive.ItemName = this.uiDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                equipment_Directive.PerformName = this.uiDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                equipment_Directive.PerformContent = this.uiDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                equipment_Directive.PerformReturn = this.uiDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                equipment_Directive.PerformOrder = this.uiDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                equipment_Directive.PerformEnable = this.uiDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            if (SqliteHelper.sqlQuery("select * from Equipment_Directive where ItemCode ='" + equipment_Directive.ItemCode + "'") > 0)
            {
                string sqlstr = string.Format("update Equipment_Directive set ItemName='{0}',PerformName='{1}',PerformContent='{2}', PerformReturn='{3}',PerformOrder={4},PerformEnable={5} where ItemCode='{6}' ", equipment_Directive.ItemName, equipment_Directive.PerformName, equipment_Directive.PerformContent, equipment_Directive.PerformReturn, equipment_Directive.PerformOrder, equipment_Directive.PerformEnable, equipment_Directive.ItemCode);
                DataGridViewNew(sqlstr,1);
               
            }
            else
            {
                if (equipment_Directive.ItemCode.Trim() != string.Empty && equipment_Directive.PerformOrder.Trim() != string.Empty)
                {
                    string sqlstr = string.Format("insert into Equipment_Directive values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}',{10},{11})", Guid.NewGuid().ToString(), equipment_Directive.ItemCode, equipment_Directive.ItemName, "管理员", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), 0, equipment_Directive.PerformName, equipment_Directive.PerformContent, equipment_Directive.PerformReturn, equipment_Directive.PerformOrder, equipment_Directive.PerformEnable, id);
                    DataGridViewNew(sqlstr,1);
                    
                }
            }
        }
        private void DataGridViewNew(string sqlstr, int code)
        {

            SQLiteConnection connection = new SQLiteConnection(SqliteHelper.connStr);

            SQLiteCommand command = new SQLiteCommand(sqlstr, connection);
            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("执行成功");
                    if (code == 1)
                    {
                        DataTable dt = (DataTable)uiDataGridView1.DataSource;
                        dt.Rows.Clear();
                        BindDataGridView();
                    }
                }
                else
                    MessageBox.Show("执行失败");
            }
            catch (System.Exception)
            {
                // MessageBox.Show(ee.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private int index = 0;
        private void uiDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                equipment_Directive.ItemCode=  this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.uiDataGridView1.Rows[e.RowIndex].Selected = true;//是否选中当前行
                index = e.RowIndex;
                this.uiDataGridView1.CurrentCell = this.uiDataGridView1.Rows[e.RowIndex].Cells[0];

                //每次选中行都刷新到datagridview中的活动单元格
                this.contextMenuStrip1.Show(this.uiDataGridView1, e.Location);
                //指定控件（DataGridView），指定位置（鼠标指定位置）
                this.contextMenuStrip1.Show(Cursor.Position);//锁定右键列表出现的位置
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.uiDataGridView1.Rows[index].IsNewRow)//判断是否为新行
            {
                string str = "update  Equipment_Directive set  isdelete =1 where ItemCode='" + equipment_Directive.ItemCode + "' ;";
                DataGridViewNew(str,0);
                this.uiDataGridView1.Rows.RemoveAt(index);//从集合中移除指定的行
                ///移除后再重新加载
                this.viewEquipment_PerformTableAdapter.Fill(this.dataSet1.ViewEquipment_Perform);
            }
        }

        #region    uiDataGridView1后续迭代优化 代码


        /// <summary>
        /// 通过自定义列的方式初始化DataGridView
        /// </summary>
        private void InitDgvByCustom()
        {
            List<string> gender = new List<string>();
            gender.Add("男");
            gender.Add("女");
            //设置要显示的列数
            uiDataGridView1.ColumnCount = 0;
            //设置标题行可见
            uiDataGridView1.ColumnHeadersVisible = true;
            //创建列
            InitDgvTextBoxColumn(this.uiDataGridView1, DataGridViewContentAlignment.MiddleCenter, "Name", "姓名", 20, false, true);
            InitDgvComboBoxColumn(this.uiDataGridView1, DataGridViewContentAlignment.MiddleCenter, "Sex", "性别", gender, false, true);
            InitDgvCheckBoxColumn(this.uiDataGridView1, DataGridViewContentAlignment.MiddleCenter, "Married", "婚否", false, true);

            //创建新行
            DataGridViewRow drRow1 = new DataGridViewRow();
            drRow1.CreateCells(this.uiDataGridView1);
            //设置单元格的值
            drRow1.Cells[0].Value = "张三";
            drRow1.Cells[1].Value = "男";
            drRow1.Cells[2].Value = true;
            //将新创建的行添加到DataGridView中
            this.uiDataGridView1.Rows.Add(drRow1);

            //创建新行
            DataGridViewRow drRow2 = new DataGridViewRow();
            drRow2.CreateCells(this.uiDataGridView1);
            //设置单元格的值
            drRow2.Cells[0].Value = "李四";
            drRow2.Cells[1].Value = "女";
            drRow2.Cells[2].Value = false;
            //将新创建的行添加到DataGridView中
            this.uiDataGridView1.Rows.Add(drRow2);

            //设置DataGridView的属性
            this.uiDataGridView1.AllowUserToAddRows = false;//不自动产生最后的新行

        }

        /// <summary>
        /// 创建DataGridView的TextBox列
        /// </summary>
        /// <param name="dgv">要创建列的DataGridView</param>
        /// <param name="_alignmeng">设置列的对齐方式</param>
        /// <param name="_columnName">列名</param>
        /// <param name="_headerText">显示的标题名</param>
        /// <param name="_maxInputLength">可输入的最大长度</param>
        /// <param name="_readOnly">设置列是否只读 true只读 false 读写</param>
        /// <param name="_visible">设置列是否可见 true 可见 false 不可见</param>
        private void InitDgvTextBoxColumn(DataGridView dgv, DataGridViewContentAlignment _alignmeng,
            string _columnName, string _headerText, int _maxInputLength, bool _readOnly, bool _visible)
        {
            //实例化一个DataGridViewTextBoxColumn列
            DataGridViewTextBoxColumn drColumn = new DataGridViewTextBoxColumn();
            //设置对齐方式
            drColumn.HeaderCell.Style.Alignment = _alignmeng;
            //设置列名
            drColumn.Name = _columnName;
            //设置标题
            drColumn.HeaderText = _headerText;
            //设置最大输入长度
            drColumn.MaxInputLength = _maxInputLength;
            //设置是否只读
            drColumn.ReadOnly = _readOnly;
            //设置是否可见
            drColumn.Visible = _visible;
            //将创建的列添加到DataGridView中
            dgv.Columns.Add(drColumn);
        }
        /// <summary>
        /// 创建DataGridView的TextBox列
        /// </summary>
        /// <param name="dgv">要创建列的DataGridView</param>
        /// <param name="_alignmeng">设置列的对齐方式</param>
        /// <param name="_columnName">列名</param>
        /// <param name="_headerText">显示的标题名</param>
        /// <param name="_gender">下拉列表Items</param>
        /// <param name="_readOnly">设置列是否只读 true只读 false 读写</param>
        /// <param name="_visible">设置列是否可见 true 可见 false 不可见</param>
        private void InitDgvComboBoxColumn(DataGridView dgv, DataGridViewContentAlignment _alignmeng,
            string _columnName, string _headerText, List<string> _gender, bool _readOnly, bool _visible)
        {
            //实例化一个DataGridViewTextBoxColumn列
            DataGridViewComboBoxColumn drColumn = new DataGridViewComboBoxColumn();
            //设置对齐方式
            drColumn.HeaderCell.Style.Alignment = _alignmeng;
            //设置列名
            drColumn.Name = _columnName;
            //设置标题
            drColumn.HeaderText = _headerText;
            //设置下拉框内容
            drColumn.DataSource = _gender;
            //设置是否只读
            drColumn.ReadOnly = _readOnly;
            //设置是否可见
            drColumn.Visible = _visible;
            //将创建的列添加到DataGridView中
            dgv.Columns.Add(drColumn);
        }
        /// <summary>
        /// 创建DataGridView的CheckBox列
        /// </summary>
        /// <param name="dgv">要创建列的DataGridView</param>
        /// <param name="_alignmeng">设置列的对齐方式</param>
        /// <param name="_columnName">列名</param>
        /// <param name="_headerText">显示的标题名</param>
        /// <param name="_readOnly">设置列是否只读 true只读 false 读写</param>
        /// <param name="_visible">设置列是否可见 true 可见 false 不可见</param>
        private void InitDgvCheckBoxColumn(DataGridView dgv, DataGridViewContentAlignment _alignmeng,
            string _columnName, string _headerText, bool _readOnly, bool _visible)
        {
            //实例化一个DataGridViewTextBoxColumn列
            DataGridViewCheckBoxColumn drColumn = new DataGridViewCheckBoxColumn();
            //设置对齐方式
            drColumn.HeaderCell.Style.Alignment = _alignmeng;
            //设置列名
            drColumn.Name = _columnName;
            //设置标题
            drColumn.HeaderText = _headerText;
            //设置是否只读
            drColumn.ReadOnly = _readOnly;
            //设置是否可见
            drColumn.Visible = _visible;
            //将创建的列添加到DataGridView中
            dgv.Columns.Add(drColumn);
        }
        #endregion
    }
}

