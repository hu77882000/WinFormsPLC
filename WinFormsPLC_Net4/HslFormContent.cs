using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPLC_Net4
{
    public partial class HslFormContent : Form
    {
        public HslFormContent()
        {
            InitializeComponent();
        }

        private void HslFormContent_Load(object sender, EventArgs e)
        {
            pnlTest.Controls.Clear();   //清空容器缓存
            //dockPanel1.Controls.Clear();  //清空容器缓存
            pnlTest.Visible = true;     //是否隐藏/显示
            int Num = 35;   //显示参数
            PictureBox[] pb = new PictureBox[Num];  //声明 PictureBox 数组
            for (int i = 0; i < Num; i++)
            {
                pb[i] = new PictureBox();  //初始化
                pb[i].BorderStyle = BorderStyle.FixedSingle;   //外边框
                pb[i].Width = 135; //Size-Width   边框宽度
                pb[i].Height = 145; //Size-Height  边框高度
                pb[i].SizeMode = PictureBoxSizeMode.CenterImage;  //里面内容是否清空
                pb[i].Image = imageList1.Images[0];   //显示图片
                pb[i].Paint += pictureBox1_Paint;     //绑定字体绘制

                pb[i].Cursor = Cursors.Hand;//鼠标悬浮样式：小手
                this.AddLableControlIntoPicBox(pb[i]);//添加
                pb[i].ContextMenuStrip = this.cmsTest;//绑定右键菜单

                pnlTest.Controls.Add(pb[i]);   //容器中添加信息
            }
        }
        #region 动态添加 PictureBox 图像控件
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

        # region   在图像控件中添加CheckBox控件
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

        private void AddLableControlIntoPicBox(PictureBox p_PicBox)
        {
            Label label = new Label();
            label.Text = "●";
            label.Font = new Font("SimSun", 16);
            label.ForeColor = Color.LightGreen;
            label.AutoSize = true;
            label.Location = new Point(-1, -1);
            p_PicBox.Controls.Add(label);
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
            PictureBox pic = new PictureBox();
            MessageBox.Show(pic.Name);
        }
        #endregion

        #region 窗体文字绘制
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
    }
}
