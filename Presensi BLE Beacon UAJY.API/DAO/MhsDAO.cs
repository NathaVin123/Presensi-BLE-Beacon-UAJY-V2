﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Presensi_BLE_Beacon_UAJY.API.Model;

namespace Presensi_BLE_Beacon_UAJY.API.DAO
{
    public class MhsDAO
    {
        public dynamic GetProfileMhs(string npm)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(DBKoneksi.koneksi);

                string query = @"SELECT m.NPM, m.NAMA_MHS
                               FROM dbo.MST_MHS_AKTIF m
                                WHERE (m.NPM = @NPM) AND m.KD_STATUS_MHS ='A'";

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

        public dynamic GetAllMhs(string npm)
        {
            OutPutApi output = new OutPutApi();
            output.status = true;
            using (SqlConnection conn = new SqlConnection(DBKoneksi.koneksi))
            {
                try
                {
                    string query = @"SELECT m.NPM, m.NAMA_MHS
                                    FROM dbo.MST_MHS_AKTIF m
                                    WHERE m.KD_STATUS_MHS ='A'";
                    var data = conn.Query<dynamic>(query, new { npm = npm }).ToList();

                    output.data = data;

                    return output;
                }
                catch (Exception ex)
                {
                    output.status = false;
                    output.pesan = ex.Message;
                    output.data = new List<string>();
                    return output;
                }
                finally
                {
                    conn.Dispose();
                }
            }
        }
    }
}