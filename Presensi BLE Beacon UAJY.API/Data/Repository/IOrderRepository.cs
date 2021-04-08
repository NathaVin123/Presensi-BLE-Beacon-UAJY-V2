namespace Presensi_BLE_Beacon_UAJY.API.Data.Repository
{
    using Presensi_BLE_Beacon_UAJY.API.Data.Entities;
    using Presensi_BLE_Beacon_UAJY.API.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrdersAsync(string userName);
        Task<IQueryable<OrderDetailTemp>> GetDetailsTempAsunc(string userName);
        Task AddItemToOrderAsync(AddItemViewModel model, string userName); 
        Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);
        Task DeleteDetailTempAsync(int id);
        Task<bool> ConfirmOrderAsync(string userName);
        Task DeliveryOrder(DeliverViewModel deliverViewModel);
        Task <Order> GetOrdersAsync(int id);


    }
}
