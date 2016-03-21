namespace PKM.UI
{
    partial class NoteEdit
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
            this.lblName = new DMSkin.Metro.Controls.MetroLabel();
            this.lblRemarks = new DMSkin.Metro.Controls.MetroLabel();
            this.dtxtRemarks = new DMSkin.Controls.DMTextBox();
            this.mtxtnotename = new DMSkin.Controls.DMTextBox();
            this.btnClose = new DMSkin.Controls.DMButton();
            this.btnSave = new DMSkin.Controls.DMButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "节点名称";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(3, 119);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(65, 20);
            this.lblRemarks.TabIndex = 1;
            this.lblRemarks.Text = "节点备注";
            // 
            // dtxtRemarks
            // 
            this.dtxtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtxtRemarks.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtxtRemarks.Location = new System.Drawing.Point(3, 142);
            this.dtxtRemarks.Multiline = true;
            this.dtxtRemarks.Name = "dtxtRemarks";
            this.dtxtRemarks.Size = new System.Drawing.Size(286, 126);
            this.dtxtRemarks.TabIndex = 2;
            this.dtxtRemarks.WaterText = "";
            // 
            // mtxtnotename
            // 
            this.mtxtnotename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtnotename.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mtxtnotename.Location = new System.Drawing.Point(3, 83);
            this.mtxtnotename.Name = "mtxtnotename";
            this.mtxtnotename.Size = new System.Drawing.Size(286, 23);
            this.mtxtnotename.TabIndex = 1;
            this.mtxtnotename.WaterText = "";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnClose.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnClose.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnClose.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnClose.DM_Radius = 5;
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(184, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnSave.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnSave.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnSave.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSave.DM_Radius = 5;
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(73, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NoteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 315);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.mtxtnotename);
            this.Controls.Add(this.dtxtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteEdit";
            this.Text = "节点属性";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMSkin.Metro.Controls.MetroLabel lblName;
        private DMSkin.Metro.Controls.MetroLabel lblRemarks;
        private DMSkin.Controls.DMTextBox dtxtRemarks;
        private DMSkin.Controls.DMTextBox mtxtnotename;
        private DMSkin.Controls.DMButton btnClose;
        private DMSkin.Controls.DMButton btnSave;
    }
}