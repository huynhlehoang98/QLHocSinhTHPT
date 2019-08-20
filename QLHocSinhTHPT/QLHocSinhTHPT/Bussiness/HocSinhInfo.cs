using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHocSinhTHPT.Bussiness
{
    class HocSinhInfo
    {
        public HocSinhInfo()
        {

        }

        private String m_MaHocSinh;
        public String MaHocSinh
        {
            get { return m_MaHocSinh; }
            set { m_MaHocSinh = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        private bool m_GioiTinh;
        public bool GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }
    }
}
