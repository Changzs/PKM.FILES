using PKM.DAO;
using PKM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.BFO
{
    public class SysDocumentClassBFO
    {
        SysDocumentClassDao dao = new SysDocumentClassDao();
        public DataTable GetDocumentClass(string fsids, int del_satus)
        {
            return dao.GetDocumentClass(fsids, del_satus);
        }
        public void Insert(string sql)
        {
            dao.Insert(sql);
        }
        public void Insert(Sys_DocumentClass sdc)
        {
            dao.Insert(sdc);
        }
    }
}
