using PKM.Common.DataBase;
using PKM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.DAO
{
    public class SysDocumentClassDao
    {
        public DataTable GetDocumentClass(string fsids, int del_satus)
        {
            string sql = string.Format(@"SELECT  d.*,s.file_name from Sys_DocumentClass d left join sys_Treeview s
                                         on d.doc_Fsid=s.sid where (  {0}=-1 or  d.doc_Fsid in ({1}) ) and d.del_status={2}", fsids, fsids, del_satus);
            return DbHelperSQLite.Query(sql).Tables[0];
        }
        public void Insert(string sql)
        {
            DbHelperSQLite.ExecuteSql(sql);
        }
        public void Insert(Sys_DocumentClass sdc)
        {
            string sql = string.Format(@"INSERT INTO Sys_DocumentClass (doc_Name,doc_savename,doc_Path,doc_Type,del_status,doc_Fsid) values
                                       ('{0}','{1}','{2}','{3}',{4},{5})", sdc.doc_Name, sdc.doc_savename, sdc.doc_Path, sdc.doc_Type, sdc.del_status, sdc.doc_Fsid);
            DbHelperSQLite.ExecuteSql(sql);
        }
    }
}
