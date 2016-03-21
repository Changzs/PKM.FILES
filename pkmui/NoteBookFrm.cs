using DMSkin;
using PKM.BFO;
using pkmui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.UI
{
    public partial class NoteBookFrm : MetroForm
    {
        SysNotebookBFO bfo = new SysNotebookBFO();
        public NoteBookFrm()
        {
            InitializeComponent();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int parentid = Convert.ToInt32(manForm.parentid);
            parentid = parentid == -1 ? 0 : parentid;
            string treetype = manForm.treetype;
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
                return;
            /**/
            string note = "";// eNotebook.HtmlEditControl.DocumentText;
            if (string.IsNullOrEmpty(note))
                return;
            string sql = string.Format(@"INSERT INTO Sys_Notebook(N_TITLE,N_CONTENT,PARENTID,TREE_TYPE)
                                        VALUES('{0}','{1}',{2},'{3}')", txtTitle.Text.Trim(), note, parentid, treetype);
            bfo.Insert(sql);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
