using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Inventorymanager2.Model
{
    public class DataProvider
    {
        private static DataProvider _ins;
        public static DataProvider Ins { get { if (_ins == null) _ins = new DataProvider(); return _ins; } set { _ins = value; } }
        public Inventory050424Entities DB { get; set; }
        private DataProvider()
        {
            DB = new Inventory050424Entities();
            

        }
    }
    //singleton
    //Quản lý: để BD chỉ được tạo ra 1 lần duy nhất
    
}
