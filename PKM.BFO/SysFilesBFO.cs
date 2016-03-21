using PKM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.BFO
{
    public class SysFilesBFO
    {
        SysFilesDao dao = new SysFilesDao();
        public DataTable GetFileList(string treetype)
        {
            return dao.GetFileList(treetype);
        }
        public void Insert(string sql) 
        {
            dao.Insert(sql);
        }
        public void DeleteBysid(int sid)
        {
            dao.DeleteBysid(sid);
        }
    }
}
