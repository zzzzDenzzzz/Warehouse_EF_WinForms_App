using Microsoft.EntityFrameworkCore;
using Warehouse_EF_WinForms_App.Constants;
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

        public async Task DeleteGoodType(int id)
        {
            var goodType = await _warehouseContext.GoodsType.FindAsync(id);
            if (goodType != null)
            {
                if (goodType.Goods != null && goodType.Goods.Any())
                {
                    throw new Exception(DatabaseDefaults.GoodsTypeDelitionIsNotPossible);
                }

                _warehouseContext.GoodsType.Remove(goodType);
                await _warehouseContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DatabaseDefaults.GoodTypeNotExist);
            }
        }

        public async Task UpdateGoodType(int id, string name)
        {
            var goodType = await _warehouseContext.GoodsType.FindAsync(id);
            goodType.Name = name;
            await _warehouseContext.SaveChangesAsync();
        }

        public string GetNameGoodType(int id)
        {
            var goodType = _warehouseContext.GoodsType.FindAsync(id);
            return goodType.Result!.Name;
        }
    }
}
