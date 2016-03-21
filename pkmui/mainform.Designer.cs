namespace pkmui
{
    partial class manForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manForm));
            this.tvList = new System.Windows.Forms.TreeView();
            this.mcmTreeView = new DMSkin.Metro.Controls.MetroContextMenu(this.components);
            this.tsmAddNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddCNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTransferNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNoteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.dmtabAll = new DMSkin.Controls.DMTabControl();
            this.tabPkm2 = new System.Windows.Forms.TabPage();
            this.dgvDocumentClass = new DMSkin.Metro.Controls.MetroGrid();
            this.doc_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_show = new System.Windows.Forms.DataGridViewLinkColumn();
            this.doc_savename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcmGrid = new DMSkin.Metro.Controls.MetroContextMenu(this.components);
            this.tsmImpDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExpAllDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExpSelDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tabNotes = new System.Windows.Forms.TabPage();
            this.tvList2 = new System.Windows.Forms.TreeView();
            this.tabtool = new System.Windows.Forms.TabPage();
            this.dmTextBox1 = new DMSkin.Controls.DMTextBox();
            this.btnRanDom = new DMSkin.Controls.DMButton();
            this.imgL_tab = new System.Windows.Forms.ImageList(this.components);
            this.imgL_tree = new System.Windows.Forms.ImageList(this.components);
            this.mcmTreeView.SuspendLayout();
            this.dmtabAll.SuspendLayout();
            this.tabPkm2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentClass)).BeginInit();
            this.mcmGrid.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.tabtool.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvList
            // 
            this.tvList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvList.ContextMenuStrip = this.mcmTreeView;
            this.tvList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tvList.LabelEdit = true;
            this.tvList.Location = new System.Drawing.Point(-1, -5);
            this.tvList.Margin = new System.Windows.Forms.Padding(0);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(184, 366);
            this.tvList.TabIndex = 1;
            this.tvList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvList_AfterSelect);
            // 
            // mcmTreeView
            // 
            this.mcmTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddNote,
            this.tsmAddCNote,
            this.tsmTransferNote,
            this.tsmDelNote,
            this.tsmAddNoteBook});
            this.mcmTreeView.Name = "mcmTreeView";
            this.mcmTreeView.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mcmTreeView.Size = new System.Drawing.Size(137, 114);
            // 
            // tsmAddNote
            // 
            this.tsmAddNote.Name = "tsmAddNote";
            this.tsmAddNote.Size = new System.Drawing.Size(136, 22);
            this.tsmAddNote.Text = "添加节点";
            this.tsmAddNote.Click += new System.EventHandler(this.tsmAddNote_Click);
            // 
            // tsmAddCNote
            // 
            this.tsmAddCNote.Name = "tsmAddCNote";
            this.tsmAddCNote.Size = new System.Drawing.Size(136, 22);
            this.tsmAddCNote.Text = "添加子节点";
            this.tsmAddCNote.Click += new System.EventHandler(this.tsmAddCNote_Click);
            // 
            // tsmTransferNote
            // 
            this.tsmTransferNote.Name = "tsmTransferNote";
            this.tsmTransferNote.Size = new System.Drawing.Size(136, 22);
            this.tsmTransferNote.Text = "移动节点";
            // 
            // tsmDelNote
            // 
            this.tsmDelNote.Name = "tsmDelNote";
            this.tsmDelNote.Size = new System.Drawing.Size(136, 22);
            this.tsmDelNote.Text = "删除节点";
            this.tsmDelNote.Click += new System.EventHandler(this.tsmDelNote_Click);
            // 
            // tsmAddNoteBook
            // 
            this.tsmAddNoteBook.Name = "tsmAddNoteBook";
            this.tsmAddNoteBook.Size = new System.Drawing.Size(136, 22);
            this.tsmAddNoteBook.Text = "记录笔记";
            this.tsmAddNoteBook.Click += new System.EventHandler(this.tsmAddNoteBook_Click);
            // 
            // dmtabAll
            // 
            this.dmtabAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmtabAll.BackColor = System.Drawing.Color.Transparent;
            this.dmtabAll.Controls.Add(this.tabPkm2);
            this.dmtabAll.Controls.Add(this.tabNotes);
            this.dmtabAll.Controls.Add(this.tabtool);
            this.dmtabAll.ImageList = this.imgL_tab;
            this.dmtabAll.ItemSize = new System.Drawing.Size(80, 32);
            this.dmtabAll.Location = new System.Drawing.Point(0, 35);
            this.dmtabAll.Margin = new System.Windows.Forms.Padding(0);
            this.dmtabAll.Name = "dmtabAll";
            this.dmtabAll.SelectedIndex = 0;
            this.dmtabAll.Size = new System.Drawing.Size(707, 397);
            this.dmtabAll.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dmtabAll.TabIndex = 2;
            this.dmtabAll.SelectedIndexChanged += new System.EventHandler(this.dmtabAll_SelectedIndexChanged);
            // 
            // tabPkm2
            // 
            this.tabPkm2.Controls.Add(this.dgvDocumentClass);
            this.tabPkm2.Controls.Add(this.tvList);
            this.tabPkm2.ImageIndex = 0;
            this.tabPkm2.Location = new System.Drawing.Point(4, 36);
            this.tabPkm2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPkm2.Name = "tabPkm2";
            this.tabPkm2.Size = new System.Drawing.Size(699, 357);
            this.tabPkm2.TabIndex = 0;
            this.tabPkm2.Text = "文档管理";
            this.tabPkm2.UseVisualStyleBackColor = true;
            // 
            // dgvDocumentClass
            // 
            this.dgvDocumentClass.AllowUserToAddRows = false;
            this.dgvDocumentClass.AllowUserToDeleteRows = false;
            this.dgvDocumentClass.AllowUserToResizeRows = false;
            this.dgvDocumentClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentClass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDocumentClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocumentClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDocumentClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDocumentClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentClass.ColumnHeadersVisible = false;
            this.dgvDocumentClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doc_type,
            this.doc_name,
            this.doc_show,
            this.doc_savename});
            this.dgvDocumentClass.ContextMenuStrip = this.mcmGrid;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumentClass.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDocumentClass.EnableHeadersVisualStyles = false;
            this.dgvDocumentClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDocumentClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDocumentClass.Location = new System.Drawing.Point(183, -1);
            this.dgvDocumentClass.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDocumentClass.Name = "dgvDocumentClass";
            this.dgvDocumentClass.ReadOnly = true;
            this.dgvDocumentClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDocumentClass.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDocumentClass.RowTemplate.Height = 23;
            this.dgvDocumentClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDocumentClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentClass.Size = new System.Drawing.Size(521, 362);
            this.dgvDocumentClass.TabIndex = 2;
            this.dgvDocumentClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentClass_CellContentClick);
            // 
            // doc_type
            // 
            this.doc_type.DataPropertyName = "doc_type";
            this.doc_type.HeaderText = "doc_type";
            this.doc_type.Name = "doc_type";
            this.doc_type.ReadOnly = true;
            this.doc_type.Visible = false;
            // 
            // doc_name
            // 
            this.doc_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doc_name.DataPropertyName = "doc_name";
            this.doc_name.HeaderText = "文档";
            this.doc_name.Name = "doc_name";
            this.doc_name.ReadOnly = true;
            // 
            // doc_show
            // 
            this.doc_show.DataPropertyName = "查看";
            this.doc_show.HeaderText = "查看";
            this.doc_show.Name = "doc_show";
            this.doc_show.ReadOnly = true;
            this.doc_show.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.doc_show.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.doc_show.Text = "查看";
            this.doc_show.UseColumnTextForLinkValue = true;
            // 
            // doc_savename
            // 
            this.doc_savename.DataPropertyName = "doc_savename";
            this.doc_savename.HeaderText = "doc_savename";
            this.doc_savename.Name = "doc_savename";
            this.doc_savename.ReadOnly = true;
            this.doc_savename.Visible = false;
            // 
            // mcmGrid
            // 
            this.mcmGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmImpDoc,
            this.tsmExpAllDoc,
            this.tsmExpSelDoc});
            this.mcmGrid.Name = "mcmGrid";
            this.mcmGrid.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mcmGrid.Size = new System.Drawing.Size(149, 70);
            // 
            // tsmImpDoc
            // 
            this.tsmImpDoc.Name = "tsmImpDoc";
            this.tsmImpDoc.Size = new System.Drawing.Size(148, 22);
            this.tsmImpDoc.Text = "导入文档";
            this.tsmImpDoc.Click += new System.EventHandler(this.tsmImpDoc_Click);
            // 
            // tsmExpAllDoc
            // 
            this.tsmExpAllDoc.Name = "tsmExpAllDoc";
            this.tsmExpAllDoc.Size = new System.Drawing.Size(148, 22);
            this.tsmExpAllDoc.Text = "导出文档";
            // 
            // tsmExpSelDoc
            // 
            this.tsmExpSelDoc.Name = "tsmExpSelDoc";
            this.tsmExpSelDoc.Size = new System.Drawing.Size(148, 22);
            this.tsmExpSelDoc.Text = "导出选中文档";
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.tvList2);
            this.tabNotes.ImageIndex = 1;
            this.tabNotes.Location = new System.Drawing.Point(4, 36);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotes.Size = new System.Drawing.Size(699, 357);
            this.tabNotes.TabIndex = 1;
            this.tabNotes.Text = "笔记本";
            this.tabNotes.UseVisualStyleBackColor = true;
            // 
            // tvList2
            // 
            this.tvList2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvList2.ContextMenuStrip = this.mcmTreeView;
            this.tvList2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tvList2.LabelEdit = true;
            this.tvList2.Location = new System.Drawing.Point(-4, -5);
            this.tvList2.Margin = new System.Windows.Forms.Padding(0);
            this.tvList2.Name = "tvList2";
            this.tvList2.Size = new System.Drawing.Size(184, 366);
            this.tvList2.TabIndex = 2;
            this.tvList2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvList_AfterSelect);
            // 
            // tabtool
            // 
            this.tabtool.Controls.Add(this.dmTextBox1);
            this.tabtool.Controls.Add(this.btnRanDom);
            this.tabtool.ImageIndex = 2;
            this.tabtool.Location = new System.Drawing.Point(4, 36);
            this.tabtool.Name = "tabtool";
            this.tabtool.Size = new System.Drawing.Size(699, 357);
            this.tabtool.TabIndex = 2;
            this.tabtool.Text = "工具";
            this.tabtool.UseVisualStyleBackColor = true;
            // 
            // dmTextBox1
            // 
            this.dmTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dmTextBox1.Location = new System.Drawing.Point(200, 33);
            this.dmTextBox1.Name = "dmTextBox1";
            this.dmTextBox1.Size = new System.Drawing.Size(199, 23);
            this.dmTextBox1.TabIndex = 2;
            this.dmTextBox1.WaterText = "";
            // 
            // btnRanDom
            // 
            this.btnRanDom.BackColor = System.Drawing.Color.Transparent;
            this.btnRanDom.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnRanDom.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnRanDom.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnRanDom.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnRanDom.DM_Radius = 5;
            this.btnRanDom.Image = null;
            this.btnRanDom.Location = new System.Drawing.Point(30, 22);
            this.btnRanDom.Name = "btnRanDom";
            this.btnRanDom.Size = new System.Drawing.Size(125, 45);
            this.btnRanDom.TabIndex = 1;
            this.btnRanDom.Text = "btnRanDom";
            this.btnRanDom.UseVisualStyleBackColor = false;
            this.btnRanDom.Click += new System.EventHandler(this.btnRanDom_Click);
            // 
            // imgL_tab
            // 
            this.imgL_tab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL_tab.ImageStream")));
            this.imgL_tab.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL_tab.Images.SetKeyName(0, "tab_doc.png");
            this.imgL_tab.Images.SetKeyName(1, "tab_note.png");
            this.imgL_tab.Images.SetKeyName(2, "tab_tool.png");
            // 
            // imgL_tree
            // 
            this.imgL_tree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL_tree.ImageStream")));
            this.imgL_tree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL_tree.Images.SetKeyName(0, "black_folder.png");
            this.imgL_tree.Images.SetKeyName(1, "black_folder_open.png");
            this.imgL_tree.Images.SetKeyName(2, "black_folder_del.png");
            // 
            // manForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(150, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(709, 429);
            this.Controls.Add(this.dmtabAll);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "manForm";
            this.ShadowType = DMSkin.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Theme = DMSkin.Metro.MetroThemeStyle.Default;
            this.mcmTreeView.ResumeLayout(false);
            this.dmtabAll.ResumeLayout(false);
            this.tabPkm2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentClass)).EndInit();
            this.mcmGrid.ResumeLayout(false);
            this.tabNotes.ResumeLayout(false);
            this.tabtool.ResumeLayout(false);
            this.tabtool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvList;
        private DMSkin.Controls.DMTabControl dmtabAll;
        private System.Windows.Forms.TabPage tabPkm2;
        private System.Windows.Forms.TabPage tabNotes;
        private DMSkin.Metro.Controls.MetroContextMenu mcmTreeView;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNote;
        private System.Windows.Forms.ToolStripMenuItem tsmAddCNote;
        private System.Windows.Forms.ToolStripMenuItem tsmTransferNote;
        private System.Windows.Forms.ToolStripMenuItem tsmDelNote;
        private System.Windows.Forms.TreeView tvList2;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNoteBook;
        private DMSkin.Metro.Controls.MetroGrid dgvDocumentClass;
        private DMSkin.Metro.Controls.MetroContextMenu mcmGrid;
        private System.Windows.Forms.ToolStripMenuItem tsmImpDoc;
        private System.Windows.Forms.ToolStripMenuItem tsmExpAllDoc;
        private System.Windows.Forms.ToolStripMenuItem tsmExpSelDoc;
        private System.Windows.Forms.TabPage tabtool;
        private DMSkin.Controls.DMButton btnRanDom;
        private DMSkin.Controls.DMTextBox dmTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_name;
        private System.Windows.Forms.DataGridViewLinkColumn doc_show;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_savename;
        private System.Windows.Forms.ImageList imgL_tree;
        private System.Windows.Forms.ImageList imgL_tab;



    }
}

