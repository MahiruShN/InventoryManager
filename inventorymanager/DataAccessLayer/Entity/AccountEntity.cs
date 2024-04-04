using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorymanager.DataAccessLayer.Entity
{
    internal class AccountEntity
    {

        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenDayDu { get; set; }
        public string TinhTrang { get; set; }
        public DateTime NgayTao { get; set; }
        public string MaQuyen { get; set; }
        public string NguoiTao { get; set; }


    }
}
