namespace Presensi_BLE_Beacon_UAJY.API.Data
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Presensi_BLE_Beacon_UAJY.API.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
        IEnumerable<SelectListItem> GetComboProducts();
    }
}
