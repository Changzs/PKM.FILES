using System;

using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.Common.DataBase
{
    public class ConfigHelper
    {
        /// <summary>
        /// 数据库链接字符串
        /// </summary>
        public static string connsqlite = ConfigurationManager.ConnectionStrings["sqliteconn"].ToString();
        /// <summary>
        /// 根节点
        /// </summary>
        public static string fileRoot = ConfigurationManager.AppSettings["FILE_ROOT"].ToString();
        /// <summary>
        /// 已删除节点
        /// </summary>
        public static string file_DelNote = ConfigurationManager.AppSettings["FILE_DELNOTE"].ToString();


        /// <summary>
        /// 允许导入的文档类型
        /// </summary>
        public static string documentType = ConfigurationManager.AppSettings["DocumentType"].ToString();
        /// <summary>
        /// 文档保存目录
        /// </summary>
        public static string documentClass_FILE = ConfigurationManager.AppSettings["DocumentClass_FILE"].ToString();

    }
}
