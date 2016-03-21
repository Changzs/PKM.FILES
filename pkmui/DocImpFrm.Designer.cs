namespace PKM.UI
{
    partial class DocImpFrm
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
            this.txtdocfile = new DMSkin.Controls.DMTextBox();
            this.dmbImp = new DMSkin.Controls.DMButton();
            this.dmb12 = new DMSkin.Controls.DMButton();
            this.dmb1 = new DMSkin.Controls.DMButton();
            this.SuspendLayout();
            // 
            // txtdocfile
            // 
            this.txtdocfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdocfile.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtdocfile.Location = new System.Drawing.Point(23, 87);
            this.txtdocfile.Name = "txtdocfile";
            this.txtdocfile.Size = new System.Drawing.Size(304, 23);
            this.txtdocfile.TabIndex = 0;
            this.txtdocfile.WaterText = "";
            // 
            // dmbImp
            // 
            this.dmbImp.BackColor = System.Drawing.Color.Transparent;
            this.dmbImp.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmbImp.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmbImp.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmbImp.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmbImp.DM_Radius = 5;
            this.dmbImp.Image = null;
            this.dmbImp.Location = new System.Drawing.Point(257, 120);
            this.dmbImp.Name = "dmbImp";
            this.dmbImp.Size = new System.Drawing.Size(77, 29);
            this.dmbImp.TabIndex = 2;
            this.dmbImp.Text = "导入";
            this.dmbImp.UseVisualStyleBackColor = false;
            this.dmbImp.Click += new System.EventHandler(this.dmbImp_Click);
            // 
            // dmb12
            // 
            this.dmb12.BackColor = System.Drawing.Color.Transparent;
            this.dmb12.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmb12.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmb12.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmb12.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmb12.DM_Radius = 5;
            this.dmb12.Image = null;
            this.dmb12.Location = new System.Drawing.Point(174, 120);
            this.dmb12.Name = "dmb12";
            this.dmb12.Size = new System.Drawing.Size(77, 29);
            this.dmb12.TabIndex = 2;
            this.dmb12.Text = "浏览目录";
            this.dmb12.UseVisualStyleBackColor = false;
            this.dmb12.Click += new System.EventHandler(this.dmb12_Click);
            // 
            // dmb1
            // 
            this.dmb1.BackColor = System.Drawing.Color.Transparent;
            this.dmb1.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmb1.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmb1.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmb1.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmb1.DM_Radius = 5;
            this.dmb1.Image = null;
            this.dmb1.Location = new System.Drawing.Point(91, 120);
            this.dmb1.Name = "dmb1";
            this.dmb1.Size = new System.Drawing.Size(77, 29);
            this.dmb1.TabIndex = 2;
            this.dmb1.Text = "浏览文件";
            this.dmb1.UseVisualStyleBackColor = false;
            this.dmb1.Click += new System.EventHandler(this.dmb1_Click);
            // 
            // DocImpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 172);
            this.Controls.Add(this.dmb1);
            this.Controls.Add(this.dmb12);
            this.Controls.Add(this.dmbImp);
            this.Controls.Add(this.txtdocfile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocImpFrm";
            this.Text = "导入文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMSkin.Controls.DMTextBox txtdocfile;
        private DMSkin.Controls.DMButton dmbImp;
        private DMSkin.Controls.DMButton dmb12;
        private DMSkin.Controls.DMButton dmb1;
    }
}