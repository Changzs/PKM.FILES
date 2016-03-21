using PKM.Common.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.DAO
{
    public class SysNotebookDao
    {
        public DataTable GetNoteBookList(string treetype)
        {
            string sql = string.Format("select * from Sys_Notebook where tree_type='{0}'", treetype);
            return DbHelperSQLite.Query(sql).Tables[0];
        }
        public void Insert(string sql)
        {
            DbHelperSQLite.ExecuteSql(sql);
        }
    }
}
