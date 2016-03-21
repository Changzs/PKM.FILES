using PKM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.BFO
{
    public class SysNotebookBFO
    {
        SysNotebookDao dao = new SysNotebookDao();
        public DataTable GetNoteBookList(string treetype)
        {
            return dao.GetNoteBookList(treetype);
        }
        public void Insert(string sql)
        {
            dao.Insert(sql);
        }
    }
}
