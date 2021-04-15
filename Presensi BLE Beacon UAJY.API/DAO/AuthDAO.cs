using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Presensi_BLE_Beacon_UAJY.API.DAO
{
    public class AuthDAO
    {
        public dynamic GetDataMhs(string npm)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(DBKoneksi.koneksi);
                string query = @"SELECT m.NPM, m.NAMA_MHS, m.PASSWORD, m.KD_STATUS_MHS
                                FROM MST_MHS_AKTIF m
                                WHERE a.NPM = @npm";

                var param = new { npm = npm };
                var data = conn.QuerySingleOrDefault<dynamic>(query, param);

                return data;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }

        public dynamic GetDataDsn(string npp)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(DBKoneksi.koneksi);
                string query = @"SELECT D.NPP, D.NAMA_DOSEN_LENGKAP
                                FROM dbo.MST_DOSEN D
                                WHERE (D.NPP = @npp) AND KD_STATUS_DOSEN ='A'";

                var param = new { npp = npp };
                var data = conn.QuerySingleOrDefault<dynamic>(query, param);

                return data;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }

        public dynamic GetProfileMhs(string npm)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(DBKoneksi.koneksi);

                string query = @"";

                var param = new { NPM = npm };
                var data = conn.QuerySingleOrDefault<dynamic>(query, param);

                return data;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }

        public dynamic GetProfileDsn(string npp)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(DBKoneksi.koneksi);

                string query = @"";

                var param = new { NPP = npp };
                var data = conn.QuerySingleOrDefault<dynamic>(query, param);

                return data;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}