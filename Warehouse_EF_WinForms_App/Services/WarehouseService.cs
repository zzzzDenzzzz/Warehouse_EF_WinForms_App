using Microsoft.EntityFrameworkCore;
using Warehouse_EF_WinForms_App.Contexts;
using Warehouse_EF_WinForms_App.Entities;

namespace Warehouse_EF_WinForms_App.Services
{
    internal class WarehouseService
    {
        readonly WarehouseContext _warehouseContext;

        public WarehouseService()
        {
            _warehouseContext = new();
        }

        public async Task<List<Good>> GetGoodsAsync()
        {
            return await _warehouseContext.Goods.ToListAsync();
        }

        public async Task<List<GoodsType>> GetGoodsTypeAsync()
        {
            return await _warehouseContext.GoodsType.ToListAsync();
        }

        public async Task<List<Delivery>> GetDeliveriesAsync()
        {
            return await _warehouseContext.Deliveries.ToListAsync();
        }

        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            return await _warehouseContext.Suppliers.ToListAsync();
        }

        public async Task AddGoodType(string goodTypeName)
        {
            var goodType = new GoodsType { Name = goodTypeName };
            await _warehouseContext.GoodsType.AddAsync(goodType);
            await _warehouseContext.SaveChangesAsync();
        }
    }
}
