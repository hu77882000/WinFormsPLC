
namespace WinFormsPLC_Net4
{
    partial class FormCurveMonitor
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
            this.button1 = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.hslCurve1 = new HslControls.HslCurve();
            this.button_read_double = new System.Windows.Forms.Button();
            this.button_read_float = new System.Windows.Forms.Button();
            this.button_read_ulong = new System.Windows.Forms.Button();
            this.button_read_long = new System.Windows.Forms.Button();
            this.button_read_uint = new System.Windows.Forms.Button();
            this.button_read_int = new System.Windows.Forms.Button();
            this.button_read_ushort = new System.Windows.Forms.Button();
            this.button_read_short = new System.Windows.Forms.Button();
            this.button_read_bool = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 66;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(701, 78);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(185, 446);
            this.propertyGrid1.TabIndex = 65;
            // 
            // hslCurve1
            // 
            this.hslCurve1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hslCurve1.BackColor = System.Drawing.Color.White;
            this.hslCurve1.FontCalibration = new System.Drawing.Font("微软雅黑", 9F);
            this.hslCurve1.Location = new System.Drawing.Point(12, 78);
            this.hslCurve1.Name = "hslCurve1";
            this.hslCurve1.Size = new System.Drawing.Size(683, 447);
            this.hslCurve1.TabIndex = 64;
            // 
            // button_read_double
            // 
            this.button_read_double.Location = new System.Drawing.Point(804, 44);
            this.button_read_double.Name = "button_read_double";
            this.button_read_double.Size = new System.Drawing.Size(82, 28);
            this.button_read_double.TabIndex = 63;
            this.button_read_double.Text = "double读取";
            this.button_read_double.UseVisualStyleBackColor = true;
            this.button_read_double.Click += new System.EventHandler(this.button_read_double_Click);
            // 
            // button_read_float
            // 
            this.button_read_float.Location = new System.Drawing.Point(716, 44);
            this.button_read_float.Name = "button_read_float";
            this.button_read_float.Size = new System.Drawing.Size(82, 28);
            this.button_read_float.TabIndex = 62;
            this.button_read_float.Text = "float读取";
            this.button_read_float.UseVisualStyleBackColor = true;
            this.button_read_float.Click += new System.EventHandler(this.button_read_float_Click);
            // 
            // button_read_ulong
            // 
            this.button_read_ulong.Location = new System.Drawing.Point(628, 44);
            this.button_read_ulong.Name = "button_read_ulong";
            this.button_read_ulong.Size = new System.Drawing.Size(82, 28);
            this.button_read_ulong.TabIndex = 61;
            this.button_read_ulong.Text = "ulong读取";
            this.button_read_ulong.UseVisualStyleBackColor = true;
            this.button_read_ulong.Click += new System.EventHandler(this.button_read_ulong_Click);
            // 
            // button_read_long
            // 
            this.button_read_long.Location = new System.Drawing.Point(540, 44);
            this.button_read_long.Name = "button_read_long";
            this.button_read_long.Size = new System.Drawing.Size(82, 28);
            this.button_read_long.TabIndex = 60;
            this.button_read_long.Text = "long读取";
            this.button_read_long.UseVisualStyleBackColor = true;
            this.button_read_long.Click += new System.EventHandler(this.button_read_long_Click);
            // 
            // button_read_uint
            // 
            this.button_read_uint.Location = new System.Drawing.Point(452, 44);
            this.button_read_uint.Name = "button_read_uint";
            this.button_read_uint.Size = new System.Drawing.Size(82, 28);
            this.button_read_uint.TabIndex = 59;
            this.button_read_uint.Text = "uint读取";
            this.button_read_uint.UseVisualStyleBackColor = true;
            this.button_read_uint.Click += new System.EventHandler(this.button_read_uint_Click);
            // 
            // button_read_int
            // 
            this.button_read_int.Location = new System.Drawing.Point(364, 44);
            this.button_read_int.Name = "button_read_int";
            this.button_read_int.Size = new System.Drawing.Size(82, 28);
            this.button_read_int.TabIndex = 58;
            this.button_read_int.Text = "int读取";
            this.button_read_int.UseVisualStyleBackColor = true;
            this.button_read_int.Click += new System.EventHandler(this.button_read_int_Click);
            // 
            // button_read_ushort
            // 
            this.button_read_ushort.Location = new System.Drawing.Point(276, 44);
            this.button_read_ushort.Name = "button_read_ushort";
            this.button_read_ushort.Size = new System.Drawing.Size(82, 28);
            this.button_read_ushort.TabIndex = 57;
            this.button_read_ushort.Text = "ushort读取";
            this.button_read_ushort.UseVisualStyleBackColor = true;
            this.button_read_ushort.Click += new System.EventHandler(this.button_read_ushort_Click);
            // 
            // button_read_short
            // 
            this.button_read_short.Location = new System.Drawing.Point(188, 44);
            this.button_read_short.Name = "button_read_short";
            this.button_read_short.Size = new System.Drawing.Size(82, 28);
            this.button_read_short.TabIndex = 56;
            this.button_read_short.Text = "short读取";
            this.button_read_short.UseVisualStyleBackColor = true;
            this.button_read_short.Click += new System.EventHandler(this.button_read_ushort_Click);
            // 
            // button_read_bool
            // 
            this.button_read_bool.Location = new System.Drawing.Point(12, 44);
            this.button_read_bool.Name = "button_read_bool";
            this.button_read_bool.Size = new System.Drawing.Size(82, 28);
            this.button_read_bool.TabIndex = 55;
            this.button_read_bool.Text = "bool读取";
            this.button_read_bool.UseVisualStyleBackColor = true;
            this.button_read_bool.Click += new System.EventHandler(this.button_read_bool_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 21);
            this.textBox1.TabIndex = 54;
            this.textBox1.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "时间间隔(ms)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 21);
            this.textBox3.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 51;
            this.label6.Text = "地址：";
            // 
            // FormCurveMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.hslCurve1);
            this.Controls.Add(this.button_read_double);
            this.Controls.Add(this.button_read_float);
            this.Controls.Add(this.button_read_ulong);
            this.Controls.Add(this.button_read_long);
            this.Controls.Add(this.button_read_uint);
            this.Controls.Add(this.button_read_int);
            this.Controls.Add(this.button_read_ushort);
            this.Controls.Add(this.button_read_short);
            this.Controls.Add(this.button_read_bool);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Name = "FormCurveMonitor";
            this.Text = "曲线图";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCurveMonitor_FormClosing);
            this.Load += new System.EventHandler(this.FormCurveMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private HslControls.HslCurve hslCurve1;
        private System.Windows.Forms.Button button_read_double;
        private System.Windows.Forms.Button button_read_float;
        private System.Windows.Forms.Button button_read_ulong;
        private System.Windows.Forms.Button button_read_long;
        private System.Windows.Forms.Button button_read_uint;
        private System.Windows.Forms.Button button_read_int;
        private System.Windows.Forms.Button button_read_ushort;
        private System.Windows.Forms.Button button_read_short;
        private System.Windows.Forms.Button button_read_bool;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
    }
}