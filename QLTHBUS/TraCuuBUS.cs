using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;
namespace QLTHBUS
{
    public class TraCuuBUS
    {
        private TraCuuDAL TraCuuDAL;

        public TraCuuBUS()
        {
            TraCuuDAL = new TraCuuDAL();
        }

        public List<TraCuuTTHSDTO> TraCuuTTHS(TraCuuTTHSDTO DTO)
        {
            return TraCuuDAL.TraCuuHocSinh(DTO);
        }

        public List<TraCuuDiemDTO> TraCuuDiem(TraCuuDiemDTO DTO)
        {
            return TraCuuDAL.TraCuuDiem(DTO);
        }
    }
}
