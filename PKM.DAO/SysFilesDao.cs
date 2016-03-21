using PKM.Common.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.DAO
{
    public class SysFilesDao
    {
        public DataTable GetFileList(string treetype) 
        {
            string sql = string.Format("select * from sys_Treeview where tree_type='{0}'", treetype);
            return DbHelperSQLite.Query(sql).Tables[0];
        }
        public void Insert(string sql)
        {
            DbHelperSQLite.ExecuteSql(sql);
        }
        public void DeleteBysid(int sid)
        {
            string sql = string.Format("delete from sys_Treeview where sid={0}", sid);
            DbHelperSQLite.ExecuteSql(sql);
        }
    }
}
