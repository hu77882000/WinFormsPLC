
namespace WinFormsPLC
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnLogin = new Sunny.UI.UIButton();
            this.txtname = new Sunny.UI.UITextBox();
            this.txtpwd = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnExit = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(13, 50);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "用户名";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLogin.Location = new System.Drawing.Point(66, 211);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 35);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.FillColor = System.Drawing.Color.White;
            this.txtname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtname.Location = new System.Drawing.Point(120, 34);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Maximum = 2147483647D;
            this.txtname.Minimum = -2147483648D;
            this.txtname.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 51);
            this.txtname.TabIndex = 2;
            this.txtname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpwd
            // 
            this.txtpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpwd.FillColor = System.Drawing.Color.White;
            this.txtpwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtpwd.Location = new System.Drawing.Point(119, 117);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpwd.Maximum = 2147483647D;
            this.txtpwd.Minimum = -2147483648D;
            this.txtpwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(237, 51);
            this.txtpwd.TabIndex = 4;
            this.txtpwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(12, 133);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "密   码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnExit.Location = new System.Drawing.Point(257, 211);
            this.btnExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "取消";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 276);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.uiLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "窗体登录";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UITextBox txtname;
        private Sunny.UI.UITextBox txtpwd;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnExit;
    }
}