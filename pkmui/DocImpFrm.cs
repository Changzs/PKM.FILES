using DMSkin;
using PKM.BFO;
using PKM.Common.DataBase;
using PKM.Model;
using pkmui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.UI
{
    public partial class DocImpFrm : MetroForm
    {
        SysDocumentClassBFO bfo = new SysDocumentClassBFO();

        string filetype = string.Empty;
        public DocImpFrm()
        {
            InitializeComponent();
        }
        private void dmbImp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdocfile.Text.Trim()))
                return;
            string treetype = manForm.treetype;
            int parentid = Convert.ToInt32(manForm.parentid);
            string doc_path = txtdocfile.Text.Trim();
            string doc_type = doc_path.Substring(doc_path.LastIndexOf(".") + 1);//文件类型
            string dco_name = doc_path.Substring(doc_path.LastIndexOf("\\") + 1);//文件名
            if (!Directory.Exists(ConfigHelper.documentClass_FILE))
                Directory.CreateDirectory(ConfigHelper.documentClass_FILE);
            string savename = DateTime.Now.ToString("yyyyMMdd") + Guid.NewGuid() + dco_name;
            File.Copy(doc_path, ConfigHelper.documentClass_FILE + savename);
            Sys_DocumentClass sdc = new Sys_DocumentClass();
            sdc.del_status = 0;
            sdc.doc_Fsid = parentid;
            sdc.doc_Name = dco_name;
            sdc.doc_Path = ConfigHelper.documentClass_FILE;
            sdc.doc_savename = savename;
            sdc.doc_Type = doc_type;
            bfo.Insert(sdc);
            MetroMessageBox.Show(this, "导入成功！");
            this.Close();
        }

        private void dmb1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = ConfigHelper.documentType;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtdocfile.Text = fileDialog.FileName;
                filetype = "浏览文件";
            }
        }

        private void dmb12_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "功能暂不实现！");
            return;
           /* FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtdocfile.Text = dialog.SelectedPath;
                CopyFile(dialog.SelectedPath, 0);
            }*/
        }

        /// <summary>
        /// 复制文件或者文件夹,并记录数据库
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="type">复制单一文件或者复制文件夹中指定类型的文件【1复制文件0复制文件夹】</param>
        private void CopyFile(string filePath, int type)
        {
            //检索文件夹
            foreach (var item in Directory.GetFiles(filePath))
            {
                string filetype = item.Substring(item.LastIndexOf(".") + 1);//文件类型
                string filename = item.Substring(item.LastIndexOf("\\") + 1);//文件名
                foreach (var item_i in Directory.GetDirectories(filePath))
                {
                }
            }
        }
    }
}
