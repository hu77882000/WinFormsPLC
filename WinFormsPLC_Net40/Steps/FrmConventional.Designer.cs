
namespace WinFormsPLC_Net40.Steps
{
    partial class FrmConventional
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
            this.hslButton1 = new HslControls.HslButton();
            this.SuspendLayout();
            // 
            // hslButton1
            // 
            this.hslButton1.CustomerInformation = null;
            this.hslButton1.Location = new System.Drawing.Point(91, 147);
            this.hslButton1.Name = "hslButton1";
            this.hslButton1.Size = new System.Drawing.Size(114, 46);
            this.hslButton1.TabIndex = 0;
            this.hslButton1.Text = "hslButton1";
            // 
            // FrmConventional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 471);
            this.Controls.Add(this.hslButton1);
            this.Name = "FrmConventional";
            this.Text = "常规";
            this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslButton hslButton1;
    }
}