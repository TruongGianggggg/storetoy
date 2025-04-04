using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class WarehouseBLL
    {
        MYKINGDOMDataContext context;
        public WarehouseBLL()
        {
            context = new MYKINGDOMDataContext();
        }

        public List<WarehouseDTO> GetListWarehouse()
        {
            var query = from kh in context.KhoHangs
                        join sp in context.SanPhams on kh.MaSanPham equals sp.MaSanPham
                        select new WarehouseDTO
                        {
                            masp = kh.MaSanPham,
                            tensp = sp.TenSanPham,
                            soluong = (int)kh.SoLuongTonKho
                        };

            return query.ToList();
        }
    }
}
