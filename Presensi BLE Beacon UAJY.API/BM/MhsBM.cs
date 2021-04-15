using Presensi_BLE_Beacon_UAJY.API.DAO;
using Presensi_BLE_Beacon_UAJY.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presensi_BLE_Beacon_UAJY.API.BM
{
    public class MhsBM
    {
        private MhsDAO dao;
        private OutPutApi output;

        public MhsBM()
        {
            dao = new MhsDAO();
            output = new OutPutApi();
        }

        public OutPutApi GetMhsProfil(string npm)
        {
            OutPutApi dt = new OutPutApi();
            dt.status = true;
            dt.pesan = "Berhasil Mengambil data";

            var data = dao.GetAllMhs(npm); ;
            if (data != null)
            {
                dt.data = data;
            }
            else
            {
                dt.status = false;
                dt.pesan = "Tidak ada data";
            }

            return dt;
        }
    }
}