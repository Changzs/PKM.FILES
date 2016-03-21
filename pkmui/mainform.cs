using DMSkin;
using DMSkin.Controls;
using DMSkin.Metro;
using PKM.BFO;
using PKM.Common.DataBase;
using PKM.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkmui
{
    public partial class manForm : MetroForm
    {
        SysDocumentClassBFO dbfo = new SysDocumentClassBFO();
        SysFilesBFO fbfo = new SysFilesBFO();

        /// <summary>
        /// 节点值
        /// </summary>
        public static string parentid = string.Empty;
        /// <summary>
        /// tab文本
        /// </summary>
        public static string treetype = string.Empty;

        DataTable dtAll = new DataTable();
        public manForm()
        {
            InitializeComponent();
            BindTree(GetTreeView());
        }


        #region BindData
        /// <summary>
        /// 加载树节点
        /// </summary>
        /// <param name="tvlist_item"></param>
        private void BindTree(TreeView tvlist_item)
        {
            //设置树节点图标
            tvlist_item.ImageList = imgL_tree;
            tvlist_item.ImageIndex = 0;
            tvlist_item.SelectedImageIndex = 1;
            tvlist_item.Nodes.Clear();
            tvlist_item.LabelEdit = true;//可编辑
            TreeNode root = new TreeNode();
            root.Text = ConfigHelper.fileRoot;
            root.Tag = -1;
            root.Name = "-1";
            dtAll = fbfo.GetFileList(dmtabAll.SelectedIndex.ToString());
            if (dtAll != null && dtAll.Rows.Count > 0)
                loadTree(dtAll.Select("parentid=0"), root);
            tvlist_item.Nodes.Add(root);
            TreeNode rootDel = new TreeNode();
            rootDel.Text = ConfigHelper.file_DelNote;
            rootDel.Tag = -2;
            rootDel.Name = "-2";
            rootDel.ImageIndex = 2;
            rootDel.SelectedImageIndex = 2;
            tvlist_item.Nodes.Add(rootDel);
        }
        /// <summary>
        /// 绑定树节点
        /// </summary>
        /// <param name="drs"></param>
        /// <param name="root"></param>
        private void loadTree(DataRow[] drs, TreeNode root)
        {
            foreach (DataRow item in drs)
            {
                TreeNode note = new TreeNode();
                note.Text = item["file_name"].ToString();
                note.Tag = item["sid"].ToString();
                note.Name = item["parentid"].ToString(); ;
                loadTree(dtAll.Select("parentid=" + Convert.ToInt32(item["sid"]) + ""), note);
                root.Nodes.Add(note);
            }
        }
        private string GetFsids(int sid)
        {
            string fsids = string.Empty;
            dtAll = fbfo.GetFileList(dmtabAll.SelectedIndex.ToString());
            if (dtAll != null && dtAll.Rows.Count > 0)
            {
                LoadSid(dtAll.Select("parentid=" + sid + ""), fsids);
            }
            return fsids;
        }
        private void LoadSid(DataRow[] drs, string sids)
        {
            foreach (DataRow item in drs)
            {
                sids += Convert.ToInt32(item["sid"]) + ",";
                LoadSid(dtAll.Select("parentid=" + Convert.ToInt32(item["sid"]) + ""), sids);
            }
        }
        #endregion


        #region treeview
        /// <summary>
        /// 当前选中tab的treeview
        /// </summary>
        /// <returns></returns>
        private TreeView GetTreeView()
        {
            TreeView tv = null;
            switch (dmtabAll.SelectedIndex)
            {
                case 0:
                    tv = tvList;
                    break;
                case 1:
                    tv = tvList2;
                    break;
                default:
                    tv = tvList;
                    break;
            }
            return tv;
        }
        /// <summary>
        /// 选中节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (GetTreeView().SelectedNode != null)
            {
                //当前选中ID
                int fsid = Convert.ToInt32(GetTreeView().SelectedNode.Tag);
                //if (fsid > -1) //不是根节点
                //{
                string sids = GetFsids(fsid) + fsid;
                dgvDocumentClass.AutoGenerateColumns = false;
                dgvDocumentClass.DataSource = dbfo.GetDocumentClass(sids, 0);
                //}
            }
            if (Convert.ToInt32(GetTreeView().SelectedNode.Tag) < -1)
            {
                GetTreeView().ContextMenuStrip = null;
            }
            else
            {
                GetTreeView().ContextMenuStrip = mcmTreeView;
            }
        }
        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddNote_Click(object sender, EventArgs e)
        {
            if (GetTreeView().SelectedNode != null)
            {
                parentid = GetTreeView().SelectedNode.Name.ToString();
                treetype = dmtabAll.SelectedIndex.ToString();
                NoteEdit ne = new NoteEdit();
                ne.ShowDialog();
                BindTree(GetTreeView());
                //if (tvList.SelectedNode != null)
                GetTreeView().ExpandAll();
            }
        }
        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddCNote_Click(object sender, EventArgs e)
        {
            if (GetTreeView().SelectedNode != null)
            {
                parentid = GetTreeView().SelectedNode.Tag.ToString();
                treetype = dmtabAll.SelectedIndex.ToString();
                NoteEdit ne = new NoteEdit();
                ne.ShowDialog();
                BindTree(GetTreeView());
                //if (tvList.SelectedNode != null)
                GetTreeView().ExpandAll();
            }
        }
        private void tsmAddNoteBook_Click(object sender, EventArgs e)
        {
            if (GetTreeView().SelectedNode != null)
            {
                parentid = GetTreeView().SelectedNode.Tag.ToString();
                treetype = dmtabAll.SelectedIndex.ToString();
                NoteBookFrm ne = new NoteBookFrm();
                ne.ShowDialog();
                BindTree(GetTreeView());
                //if (tvList.SelectedNode != null)
                GetTreeView().ExpandAll();
            }
        }
        private void tsmDelNote_Click(object sender, EventArgs e)
        {
            if (GetTreeView().SelectedNode != null)
            {
                int sid = Convert.ToInt32(GetTreeView().SelectedNode.Tag);
                fbfo.DeleteBysid(sid);
                BindTree(GetTreeView());
                GetTreeView().ExpandAll();
            }
        }
        #endregion

        /// <summary>
        /// 切换Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dmtabAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindTree(GetTreeView());
        }

        #region 绑定列表的右键事件

        private void tsmImpDoc_Click(object sender, EventArgs e)
        {
            if (GetTreeView().SelectedNode != null)
            {
                parentid = GetTreeView().SelectedNode.Tag.ToString();
                treetype = dmtabAll.SelectedIndex.ToString();
                DocImpFrm ne = new DocImpFrm();
                ne.ShowDialog();
                BindTree(GetTreeView());
                //if (tvList.SelectedNode != null)
                GetTreeView().ExpandAll();
            }
        }


        #endregion

        private void btnRanDom_Click(object sender, EventArgs e)
        {
            dmTextBox1.Text = DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(100);
        }

        private void dgvDocumentClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string savename = dgvDocumentClass.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dgvDocumentClass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "查看" && !string.IsNullOrEmpty(savename))
                {
                    System.Diagnostics.ProcessStartInfo sinfo = new System.Diagnostics.ProcessStartInfo();
                    sinfo.WorkingDirectory = ConfigHelper.documentClass_FILE;
                    sinfo.FileName = savename;
                    System.Diagnostics.Process.Start(sinfo);
                }
            }
        }








    }
}
