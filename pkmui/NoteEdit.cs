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
    public partial class NoteEdit : MetroForm
    {
        SysFilesBFO bfo = new SysFilesBFO();
        public NoteEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int parentid = Convert.ToInt32(manForm.parentid);
            parentid = parentid == -1 ? 0 : parentid;
            string treetype = manForm.treetype;

            if (string.IsNullOrEmpty(mtxtnotename.Text.Trim()))
                return;
            string sql = string.Format(@"INSERT INTO sys_Treeview(FILE_NAME,parentid,orderid,remarks,tree_type)
                          VALUES ('{0}',{1},'{2}','{3}','{4}')", mtxtnotename.Text.Trim(), parentid, 1, dtxtRemarks.Text.Trim(), treetype);
            bfo.Insert(sql);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
