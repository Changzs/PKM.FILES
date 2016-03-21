using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.Model
{
    public class Sys_DocumentClass
    {    
        public int sid { get; set; }
        public string doc_Name { get; set; } 
        public string doc_savename { get; set; }
        public string doc_Path { get; set; }   
        public string doc_Type { get; set; }
        public int del_status { get; set; }
        public int doc_Fsid { get; set; }

    }
}
