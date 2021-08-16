using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WinFormsPLC_Net40
{
    public partial class FrmAddIPEquipment : DockContent
    {
        public FrmAddIPEquipment()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (Control c in uiCheckBoxGroup1.Controls)
            {
                this.txtDataBits.Text = "";
                this.txtIp.Text = "";
                this.txtIPStandNo.Text = "";
                this.txtName.Text = "";
                this.txtPort.Text = "";
                this.txtSerialNum.Text = "";
                this.txtStandNO.Text = "";
                this.txtStopBits.Text = "";
                this.cmbBaudRate.Text = "请选择";
                this.cmbBrand.Text = "请选择";
                this.cmbComm.Text = "请选择";
                this.cmbModel.Text = "请选择";
                this.cmbParity.Text = "请选择";
                this.cmbSerialPort.Text = "请选择";
                this.cmbStartupOrder.Text = "请选择";
            }
        }

        private void cmbComm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbComm.SelectedIndex == 0)
            {
                uiCheckBoxGroup2.Visible = true;
                uiCheckBoxGroup1.Visible = false;
            }
            else if (cmbComm.SelectedIndex == 1)
            {
                uiCheckBoxGroup2.Visible = false;
                uiCheckBoxGroup1.Visible = true;
            }
            else MessageBox.Show(cmbComm.Text);
        }
        private void FrmAddIPEquipment_Load(object sender, EventArgs e)
        {
            uiCheckBoxGroup2.Visible = true;
            uiCheckBoxGroup1.Visible = false;
            txtWorkstation.Text = Dns.GetHostName();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string brand = this.cmbBrand.Text.Trim();
            string model = this.cmbModel.Text.Trim();
            string Name = this.txtName.Text.Trim();
            string ItemName = this.txtSerialNum.Text.Trim();
            string StartupOrder = this.cmbStartupOrder.Text.Trim();
            string Positions = this.cmbPositions.Text.Trim();
            if (cmbComm.SelectedIndex == 0)
            {
                string ip = this.txtIp.Text.Trim();
                string port = this.txtPort.Text.Trim();
                string sandNo = this.txtIPStandNo.Text.Trim();
                string RegisterAddress = this.RegisterAddress.Text.Trim();
                string CommunicationTypeID = (string)SqliteHelper.ExecuteScalar("select id from PT_CommunicationTypes where ItemName ='" + this.cmbComm.Text+"'");
                if (ip.Length > 0 && port.Length > 0 && sandNo.Length > 0 && RegisterAddress.Length > 0)
                {
                    if (SqliteHelper.sqlQuery("select * from PT_Term  where ItemCode like '%" + ItemName + "%'") == 0)
                    {
                        try
                        {
                            var uuid = Guid.NewGuid().ToString();
                            string sql = string.Format("insert into PT_Term values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9},{10},{11})", uuid, ItemName, Name, "管理员", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), "0", CommunicationTypeID, brand, model,0,StartupOrder,Positions);
                            bool result = SqliteHelper.OperationDB(sql);
                            string TremID = (string)SqliteHelper.ExecuteScalar("select id from PT_Term where ItemCode ='" + ItemName + "'");

                            string sql1 = string.Format("insert into PT_IPAddress values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}','{10}',{11})", uuid, CommunicationTypeID, Name, "管理员", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), "0", ip, port, sandNo, RegisterAddress, TremID, 0);

                            bool result1 = SqliteHelper.OperationDB(sql1);
                            if (result1)  MessageBox.Show("保存成功");
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("保存失败！错误原因：" + ex.Message);
                        }
                    }
                    else MessageBox.Show("数据已添加，请不要重复添加");
                }
                else  MessageBox.Show("参数不能为空");
            }
            else if (cmbComm.SelectedIndex == 1)
            {
                string SerialPort = this.cmbSerialPort.Text.Trim();
                string BaudRate = this.cmbBaudRate.Text.Trim();
                string DataBits = this.txtDataBits.Text.Trim();
                string StopBits = this.txtStopBits.Text.Trim();
                string Parity = this.cmbParity.Text.Trim();
                string SerialNo = this.txtStandNO.Text.Trim();

                string CommunicationTypeID = (string)SqliteHelper.ExecuteScalar("select id from PT_CommunicationTypes where ItemName ='" + this.cmbComm.Text + "'");
                if (SerialPort.Length > 0 && BaudRate.Length > 0 && DataBits.Length > 0 && StopBits.Length > 0)
                {
                    if (SqliteHelper.sqlQuery("select * from PT_Term  where ItemCode like '%" + ItemName + "%'") == 0)
                    {
                        try
                        {
                            var uuid = Guid.NewGuid().ToString();
                            string sql = string.Format("insert into PT_Term values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9},{10},{11})", uuid, ItemName, Name, "管理员", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), "0", CommunicationTypeID, brand, model,0, StartupOrder, Positions);
                            bool result = SqliteHelper.OperationDB(sql);
                            string TremID = (string)SqliteHelper.ExecuteScalar("select id from PT_Term where ItemCode ='" + ItemName+"'");
                            string sql1 = string.Format("insert into PT_RS232Address values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}','{10}',{11},'{12}',{13})", uuid, CommunicationTypeID, Name, SerialPort, BaudRate, DataBits, StopBits, Parity, SerialNo, "管理员", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), "0", TremID, 0);
                            bool result1 = SqliteHelper.OperationDB(sql1);
                            if (result1)  MessageBox.Show("保存成功");
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("保存失败！错误原因：" + ex.Message);
                        }
                    }
                    else  MessageBox.Show("数据已添加，请不要重复添加");
                }
                else  MessageBox.Show("参数不能为空");
            }
        }
    }
}
