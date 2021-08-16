namespace WinFrmUpdate
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_reconnect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_reconnect
            // 
            this.label_reconnect.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reconnect.ForeColor = System.Drawing.Color.Red;
            this.label_reconnect.Location = new System.Drawing.Point(56, 199);
            this.label_reconnect.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_reconnect.Name = "label_reconnect";
            this.label_reconnect.Size = new System.Drawing.Size(381, 40);
            this.label_reconnect.TabIndex = 6;
            this.label_reconnect.Text = "连接断开，正在重连中...";
            this.label_reconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_reconnect.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 133);
            this.label1.TabIndex = 5;
            this.label1.Text = "正在分析升级信息......";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.GhostWhite;
            this.progressBar1.Location = new System.Drawing.Point(58, 154);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(706, 40);
            this.progressBar1.TabIndex = 4;
            // 
            // label_progress
            // 
            this.label_progress.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progress.ForeColor = System.Drawing.Color.Brown;
            this.label_progress.Location = new System.Drawing.Point(504, 199);
            this.label_progress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(260, 40);
            this.label_progress.TabIndex = 7;
            this.label_progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 248);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.label_reconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_reconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_progress;
    }
}

