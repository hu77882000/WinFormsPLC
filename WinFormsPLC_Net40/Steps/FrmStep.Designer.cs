
namespace WinFormsPLC_Net40.Steps
{
    partial class FrmStep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStep));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNew = new Sunny.UI.UIButton();
            this.btnInsert = new Sunny.UI.UIButton();
            this.btnUpdate = new Sunny.UI.UIButton();
            this.btnDel = new Sunny.UI.UIButton();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.ImageBtn2 = new Sunny.UI.UIImageButton();
            this.ImageBtn1 = new Sunny.UI.UIImageButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Failure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "作业步骤列表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "操作步骤：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "开始步骤：";
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnNew.Location = new System.Drawing.Point(12, 448);
            this.btnNew.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 24);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnInsert.Location = new System.Drawing.Point(174, 448);
            this.btnInsert.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 24);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "插入";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(369, 448);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 24);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "编辑";
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDel.Location = new System.Drawing.Point(539, 448);
            this.btnDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(111, 24);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            // 
            // cmbStep
            // 
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(338, 413);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(328, 20);
            this.cmbStep.TabIndex = 8;
            // 
            // ImageBtn2
            // 
            this.ImageBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageBtn2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ImageBtn2.Image = ((System.Drawing.Image)(resources.GetObject("ImageBtn2.Image")));
            this.ImageBtn2.Location = new System.Drawing.Point(113, 415);
            this.ImageBtn2.Name = "ImageBtn2";
            this.ImageBtn2.Size = new System.Drawing.Size(31, 27);
            this.ImageBtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtn2.TabIndex = 10;
            this.ImageBtn2.TabStop = false;
            this.ImageBtn2.Text = null;
            // 
            // ImageBtn1
            // 
            this.ImageBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageBtn1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ImageBtn1.Image = ((System.Drawing.Image)(resources.GetObject("ImageBtn1.Image")));
            this.ImageBtn1.Location = new System.Drawing.Point(76, 415);
            this.ImageBtn1.Name = "ImageBtn1";
            this.ImageBtn1.Size = new System.Drawing.Size(31, 27);
            this.ImageBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtn1.TabIndex = 9;
            this.ImageBtn1.TabStop = false;
            this.ImageBtn1.Text = null;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.step,
            this.name,
            this.Column3,
            this.ReturnValue,
            this.CHE,
            this.Failure});
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(7, 33);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.uiDataGridView1.RowTemplate.Height = 23;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(665, 361);
            this.uiDataGridView1.TabIndex = 11;
            this.uiDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellDoubleClick);
            this.uiDataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.uiDataGridView1_RowPostPaint);
            // 
            // step
            // 
            this.step.HeaderText = "步骤";
            this.step.Name = "step";
            this.step.Width = 50;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "执行内容";
            this.Column3.Name = "Column3";
            // 
            // ReturnValue
            // 
            this.ReturnValue.HeaderText = "返回值";
            this.ReturnValue.Name = "ReturnValue";
            // 
            // CHE
            // 
            this.CHE.HeaderText = "成功时";
            this.CHE.Name = "CHE";
            // 
            // Failure
            // 
            this.Failure.HeaderText = "失败时";
            this.Failure.Name = "Failure";
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton1.Image")));
            this.uiImageButton1.Location = new System.Drawing.Point(159, 415);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(34, 28);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 12;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = null;
            // 
            // FrmStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 485);
            this.Controls.Add(this.uiImageButton1);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.ImageBtn2);
            this.Controls.Add(this.ImageBtn1);
            this.Controls.Add(this.cmbStep);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmStep";
            this.Text = "步骤";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton btnNew;
        private Sunny.UI.UIButton btnInsert;
        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIButton btnDel;
        private System.Windows.Forms.ComboBox cmbStep;
        private Sunny.UI.UIImageButton ImageBtn1;
        private Sunny.UI.UIImageButton ImageBtn2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn step;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Failure;
        private Sunny.UI.UIImageButton uiImageButton1;
    }
}