using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPLC_Net40.GlobalClass;

namespace WinFormsPLC_Net40
{
    public partial class HslFormContent : Form
    {
        public HslFormContent()
        {
            InitializeComponent();
        }
        private PictureBox ctlPicBox;
        private void HslFormContent_Load(object sender, EventArgs e)
        {
            pnlTest.Controls.Clear();   //清空容器缓存
            btnLoading_Click(null, new EventArgs());
        }
        #region 动态创建pic 图片窗体
        /// <summary>
        /// 动态创建pic 图片窗体
        /// </summary>
        /// <param name="PicNo">编号</param>
        /// <param name="PicName">设备名称</param>
        private void PicAdd(string PicNo, string PicName)
        {
            // pnlTest.Controls.Clear();   //清空容器缓存
            pnlTest.Visible = true;     //是否隐藏/显示
            PictureBox pb = new PictureBox();  //初始化
            pb.Name = PicNo ;
            pb.BorderStyle = BorderStyle.FixedSingle;   //外边框
            pb.Width = 82; //Size-Width   边框宽度
            pb.Height = 82; //Size-Height  边框高度
            pb.SizeMode = PictureBoxSizeMode.CenterImage;  //图片居中
            pb.Image = imageList1.Images[0];   //显示图片
           // pb.Paint += pictureBox1_Paint;     //绑定字体绘制
            pb.MouseClick += pictureBox1_MouseClick;
            pb.Cursor = Cursors.Hand;//鼠标悬浮样式：小手
            this.AddLableControlIntoPicBox(pb, Color.LimeGreen);//添加 左上角的状态
            this.AddLableIntoPicBox(pb, PicName , "COM6");
            pb.ContextMenuStrip = this.cmsTest;//绑定右键菜单
             // pnlTest.VerticalScroll.Visible = true;   //显示滚动条
            pb.Margin = new Padding(5);
            pnlTest.Controls.Add(pb);   //容器中添加信息
             //pb.BringToFront();  //现在是Z轴上
        }

        #endregion

        #region 绘制 左上角的状态
        /// <summary>
        /// 绘制 左上角的状态
        /// </summary>
        /// <param name="p_PicBox"></param>
        private void AddLableControlIntoPicBox(PictureBox p_PicBox, Color color)
        {
            Label label = new Label();
            label.Text = "●";
            label.Font = new Font("SimSun", 16);
            label.ForeColor = color;
            label.AutoSize = true;
            label.Location = new Point(-1, -1);
            p_PicBox.Controls.Add(label);
        }
#endregion

        #region 添加lable标签
        /// <summary>
        ///  添加lable标签 文字绘画
        /// </summary>
        /// <param name="pictureBox"> 图片pictureBox</param>
        /// <param name="Name">文字名称</param>
        /// <param name="serialPort">端口</param>
        private void AddLableIntoPicBox(PictureBox pictureBox, string Name, string serialPort)
        {
            Label label = new Label();
            label.Text = Name + "【" + serialPort + "】";
            label.Font = new Font("微软雅黑", 10);
            label.ForeColor = Color.Black;
            label.AutoSize = true;
            label.Location = new Point(5, 65);
            pictureBox.Controls.Add(label);

        }
        #endregion

        #region  pictureBox 单击事件
        /// <summary>
        ///  pictureBox 单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string picName = (sender as PictureBox).Name;
            MessageBox.Show(picName);
        }
        #endregion

        #region  右键菜单 管理
        /// <summary>
        /// 右键菜单  设置参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 设置参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlcEntity.SerialNumber = ctlPicBox.Name;
            FrmSetup frm = new FrmSetup();
            frm.Show();
        }
        /// <summary>
        /// 右键打开菜单 获取打开时控件信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsTest_Opening(object sender, CancelEventArgs e)
        {
            ctlPicBox = (PictureBox)(sender as ContextMenuStrip).SourceControl;
        }
        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 加载按钮
        /// <summary>
        /// 加载按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoading_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(SqliteHelper.connStr))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = string.Format("select Count(1) as count ,ItemCode,ItemName from PT_Term  where isdelete =0 group by ItemCode,ItemName;");
                    using (SQLiteDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                        {
                            PicAdd(dr["ItemCode"].ToString(), dr["ItemName"].ToString());
                        }
                    }

                }
            }
        }
        #endregion

        #region 动态添加 PictureBox 图像控件  已弃用
        /// <summary>
        /// 动态添加图像控件
        /// </summary>
        private void AddPicControl()
        {
            PictureBox pic = new PictureBox();
            //设置图像相关属性及事件
            pic.Name = string.Format("pic{0}", this.pnlTest.Controls.Count);//Name属性
            pic.Width = 120; //Size-Width
            pic.Height = 120; //Size-Height
            pic.BorderStyle = BorderStyle.FixedSingle;//边框样式：单线边
            pic.Location = new Point(100, 200);
            pic.SizeMode = PictureBoxSizeMode.Zoom;//设置图像SizeMode=Zoom
            pic.Image = imageList1.Images[0];
            pic.Cursor = Cursors.Hand;//鼠标悬浮样式：小手
            this.AddCheckBoxControlIntoPicBox(pic);//添加复选框
            pic.ContextMenuStrip = this.cmsTest;//绑定右键菜单
                                                //向容器中添加一个图像控件
            this.pnlTest.Controls.Add(pic);
        }
        #endregion

        #region   在图像控件中添加CheckBox控件  已弃用
        /// <summary>
        /// 在图像控件中添加CheckBox控件
        /// </summary>
        private void AddCheckBoxControlIntoPicBox(PictureBox p_PicBox)
        {
            CheckBox chkBox = new CheckBox();
            chkBox.Name = string.Format("chkBoxOf{0}", p_PicBox.Name);
            chkBox.Text = string.Empty;
            chkBox.AutoSize = true;//若不设置此属性，会出现比较多的白色边框，比较难看
            chkBox.Location = new Point(-1, -1);//相对位置：左上角

            p_PicBox.Controls.Add(chkBox);
        }

        #endregion

        #region 窗体文字绘制   已弃用
        /// <summary>
        /// 窗体文字绘制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawString("设备", new Font("Arial ", 10, FontStyle.Bold), SystemBrushes.ActiveCaptionText, new PointF(50, 120));
        }

        #endregion

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            //已知多少设备 未删除的状态 返回id
            string str = "select id from PT_Term where  isdelete = 0";
            string id = (String)SqliteHelper.ExecuteScalar(str, null);

            //根据设备列表查询设备指令配置列表的排序 返回一个dataset
            SQLiteConnection conn = new SQLiteConnection(SqliteHelper.connStr);
            string str2 = string.Format("select * from Equipment_Directive where isdelete= 0 and DeviceType in ('{0}')");
            DataSet ds = SqliteHelper.ExecuteDataSet(conn, str2, null);
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                foreach (DataColumn mDc in ds.Tables[0].Columns)
                {
                    Console.WriteLine(mDr[mDc].ToString());
                }
            }
            //发送设备指定
            //判断指令的是否正常有参数返回 且返回与返回值对比
            // 是
            // 否  返回状态信息，已红色标记报警  
            // 报警信息推送至PLC


        }
    }
}
