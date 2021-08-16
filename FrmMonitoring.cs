using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPLC
{
    public partial class FrmMonitoring : Form
    {
        public FrmMonitoring()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前界面
            if (uiButton1.Text == "打开监听")
            {
                uiButton1.Text = "关闭监听";
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Thread thread = new Thread();
        }
    }
}
