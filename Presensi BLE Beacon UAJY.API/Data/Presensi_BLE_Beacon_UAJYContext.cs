using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Presensi_BLE_Beacon_UAJY.API.Models;

namespace Presensi_BLE_Beacon_UAJY.API.Data
{
    public class Presensi_BLE_Beacon_UAJYContext : DbContext
    {
        public Presensi_BLE_Beacon_UAJYContext (DbContextOptions<Presensi_BLE_Beacon_UAJYContext> options)
            : base(options)
        {
        }

        public DbSet<Presensi_BLE_Beacon_UAJY.API.Models.Mahasiswa> Mahasiswa { get; set; }
    }
}
