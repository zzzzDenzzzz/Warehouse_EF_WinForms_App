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

        #region [GetWarehouseContext]

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

        #endregion

        #region [Good_Type Add, Update, Delete, GetName]

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
                throw new Exception(DatabaseDefaults.ObjectNotExist);
            }
        }

        public async Task UpdateGoodType(int id, string name)
        {
            var goodType = await _warehouseContext.GoodsType.FindAsync(id);
            if (goodType != null)
            {
                goodType.Name = name;
                await _warehouseContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DatabaseDefaults.ObjectNotExist);
            }
        }

        public string GetNameGoodType(int id)
        {
            var goodType = _warehouseContext.GoodsType.FindAsync(id);
            return goodType.Result!.Name;
        }

        #endregion

        #region [Supplier Add, Update, Delete, GetName]

        public async Task AddSupplier(string supplierName)
        {
            var supplier = new Supplier { Name = supplierName };
            await _warehouseContext.Suppliers.AddAsync(supplier);
            await _warehouseContext.SaveChangesAsync();
        }

        public async Task DeleteSupplier(int id)
        {
            var supplier = await _warehouseContext.Suppliers.FindAsync(id);
            if (supplier != null)
            {
                if (supplier.Deliveries != null && supplier.Deliveries.Any())
                {
                    throw new Exception(DatabaseDefaults.DeliveriesDelitionIsNotPossible);
                }

                _warehouseContext.Suppliers.Remove(supplier);
                await _warehouseContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DatabaseDefaults.ObjectNotExist);
            }
        }

        public async Task UpdateSupplier(int id, string name)
        {
            var supplier = await _warehouseContext.Suppliers.FindAsync(id);
            if (supplier != null)
            {
                supplier.Name = name;
                await _warehouseContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DatabaseDefaults.ObjectNotExist);
            }
        }

        public string GetNameSupplier(int id)
        {
            var supplier = _warehouseContext.Suppliers.FindAsync(id);
            return supplier.Result!.Name;
        }

        #endregion

        #region [Good Add, Update, Delete, GetName, GetCost, GetGoodTypeId]

        public async Task<List<KeyValuePair<string, int>>> GetGoodTypesPairs()
        {
            return await _warehouseContext.GoodsType
                .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
                .ToListAsync();
        }

        public async Task AddGood(string goodName, decimal cost, int goodTypeId)
        {
            var good = new Good { Name = goodName, Cost = cost, GoodsTypeId = goodTypeId };
            await _warehouseContext.Goods.AddAsync(good);
            await _warehouseContext.SaveChangesAsync();
        }

        public async Task DeleteGood(int id)
        {
            var good = await _warehouseContext.Goods.FindAsync(id);
            if (good != null)
            {
                _warehouseContext.Goods.Remove(good);
                await _warehouseContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DatabaseDefaults.ObjectNotExist);
            }
        }

        public async Task UpdateGood(int id, string name, decimal cost, int goodTypeId)
        {
            var good = await _warehouseContext.Goods.FindAsync(id);
            if (good != null)
            {
                good.Name = name;
                good.Cost = cost;
                good.GoodsTypeId = goodTypeId;
                await _warehouseContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DatabaseDefaults.ObjectNotExist);
            }
        }

        public string GetNameGood(int id)
        {
            var good = _warehouseContext.Goods.FindAsync(id);
            return good.Result!.Name;
        }

        public decimal GetCostGood(int id)
        {
            var good = _warehouseContext.Goods.FindAsync(id);
            return good.Result!.Cost;
        }

        public int GetGoodTypeId(int id)
        {
            var good = _warehouseContext.Goods.FindAsync(id);
            return good.Result!.GoodsTypeId;
        }

        public async Task<Good?>GetGoodById(int id)
        {
            return await _warehouseContext.Goods.FindAsync(id);
        }

        public async Task EditGood(Good good, string newName, decimal newCost, int newGoodTypeId)
        {
            good.Name = newName;
            good.Cost = newCost;
            good.GoodsTypeId = newGoodTypeId;
            await _warehouseContext.SaveChangesAsync();
        }

        #endregion
    }
}
