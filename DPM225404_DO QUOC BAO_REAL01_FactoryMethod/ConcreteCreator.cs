using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_REAL01_FactoryMethod
{
    class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new TrangKyNang());
            Pages.Add(new TrangGiaoDuc());
            Pages.Add(new TrangKinhNghiem());
        }
    }
    class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new TrangGioiThieu());
            Pages.Add(new TrangKetQua());
            Pages.Add(new TrangKetLuan());
            Pages.Add(new TrangTomTat());
            Pages.Add(new TrangTaiLieuThamKhao());
        }
    }
}
