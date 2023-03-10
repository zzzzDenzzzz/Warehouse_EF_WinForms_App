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

        #region [WarehouseContext Read]

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

        #region [Good_Type Add, Update, Delete, GetGoodTypeById]

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
                    throw new Exception(DatabaseDefaults.DelitionIsNotPossible);
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

        public async Task<GoodsType?> GetGoodTypeById(int id)
        {
            return await _warehouseContext.GoodsType.FindAsync(id);
        }

        #endregion

        #region [Supplier Add, Update, Delete, GetSupplierById]

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
                    throw new Exception(DatabaseDefaults.DelitionIsNotPossible);
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

        public async Task<Supplier?> GetSupplierById(int id)
        {
            return await _warehouseContext.Suppliers.FindAsync(id);
        }

        #endregion

        #region [Good Add, Update, Delete, GetGoodById]

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
                if (good.Deliveries != null && good.Deliveries.Any())
                {
                    throw new Exception(DatabaseDefaults.DelitionIsNotPossible);
                }
                _warehouseContext.Goods.Remove(good);
                await _warehouseContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DatabaseDefaults.ObjectNotExist);
            }
        }

        public async Task<Good?> GetGoodById(int id)
        {
            return await _warehouseContext.Goods.FindAsync(id);
        }

        public async Task UpdateGood(Good good, string newName, decimal newCost, int newGoodTypeId)
        {
            good.Name = newName;
            good.Cost = newCost;
            good.GoodsTypeId = newGoodTypeId;
            await _warehouseContext.SaveChangesAsync();
        }

        #endregion

        #region [Delivery Add, Update, Delete, GetDeliveryById]

        public async Task<List<KeyValuePair<string, int>>> GetGoodPairs()
        {
            return await _warehouseContext.Goods
                .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
                .ToListAsync();
        }

        public async Task<List<KeyValuePair<string, int>>> GetSupplierPairs()
        {
            return await _warehouseContext.Suppliers
                .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
                .ToListAsync();
        }

        public async Task AddDelivery(int amount, DateTime date, int goodId, int supplierId)
        {
            var delivery = new Delivery
            {
                Amount = amount,
                DeliveryDate = date,
                GoodsId = goodId,
                SupplierId = supplierId
            };
            await _warehouseContext.Deliveries.AddAsync(delivery);
            await _warehouseContext.SaveChangesAsync();
        }

        public async Task DeleteDelivery(int id)
        {
            var delivery = await _warehouseContext.Deliveries.FindAsync(id);
            if (delivery != null)
            {
                _warehouseContext.Deliveries.Remove(delivery);
                await _warehouseContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DatabaseDefaults.ObjectNotExist);
            }
        }

        public async Task<Delivery?> GetDeliveryById(int id)
        {
            return await _warehouseContext.Deliveries.FindAsync(id);
        }

        public async Task UpdateDelivery(Delivery delivery, int newAmount, DateTime newDate, int newGoodId, int newSupplierId)
        {
            delivery.Amount = newAmount;
            delivery.DeliveryDate = newDate;
            delivery.GoodsId = newGoodId;
            delivery.SupplierId = newSupplierId;
            await _warehouseContext.SaveChangesAsync();
        }

        #endregion

        #region [Queries]

        // показать товар с максимальным количеством
        public async Task<Good> GetGoodMaxAmountAsync()
        {
            if (_warehouseContext.Deliveries.Any())
            {
                var max = await _warehouseContext.Deliveries
                .GroupBy(p => p.GoodsId)
                .Select(p => new { GoodsId = p.Key, AmountSum = p.Sum(p => p.Amount) })
                .OrderByDescending(p => p.AmountSum)
                .FirstAsync();

                var goods = await _warehouseContext.Goods
                    .FindAsync(max.GoodsId);

                if (goods != null)
                {
                    return goods;
                }
                throw new Exception("Поставщик не найден");
            }
            throw new Exception("Нет товара");
        }

        // показать товар с минимальным количеством
        public async Task<Good> GetGoodMinAmountAsync()
        {
            if (_warehouseContext.Deliveries.Any())
            {
                var min = await _warehouseContext.Deliveries
                .GroupBy(p => p.GoodsId)
                .Select(p => new { GoodsId = p.Key, AmountSum = p.Sum(p => p.Amount) })
                .OrderBy(p => p.AmountSum)
                .FirstAsync();

                var goods = await _warehouseContext.Goods
                    .FindAsync(min.GoodsId);

                if (goods != null)
                {
                    return goods;
                }
                throw new Exception("Поставщик не найден");
            }
            throw new Exception("Нет товара");
        }

        // показать товар с минимальной себестоимостью
        public async Task<Good> GetGoodMinCostAsync()
        {
            var good = await _warehouseContext.Goods
                .OrderBy(g => g.Cost)
                .FirstAsync();

            if (good != null)
            {
                return good;
            }
            throw new Exception("Нет товара");
        }

        // показать товар с максимальной себестоимостью
        public async Task<Good> GetGoodMaxCostAsync()
        {
            var good = await _warehouseContext.Goods
                .OrderByDescending(g => g.Cost)
                .FirstAsync();

            if (good != null)
            {
                return good;
            }
            throw new Exception("Нет товара");
        }

        // показать, товары заданной категории
        public async Task<List<Good>> GetGoodSetGoodType(int idGoodType)
        {
            var listGoods = await _warehouseContext.Goods
                .Where(g => g.GoodsType.Id == idGoodType)
                .ToListAsync();

            if (listGoods != null)
            {
                return listGoods;
            }
            throw new Exception("Нет товара");
        }

        // показать, товары заданного поставщика
        public async Task<List<Good>> GetGoodSetSuplier(int idSupplier)
        {
            var supplier = await _warehouseContext.Suppliers
                .Where(s => s.Id == idSupplier)
                .SingleOrDefaultAsync();

            if (supplier != null)
            {
                var listGoods = await _warehouseContext.Deliveries
                .Where(d => d.SupplierId == supplier.Id)
                .Select(d => d.Goods)
                .ToListAsync();

                if (listGoods != null)
                {
                    return listGoods;
                }
            }
            
            throw new Exception("Нет товара");
        }

        // показать самый старый товар на складе
        public async Task<Good> GetOldestGoodInWarehouse()
        {
            return await _warehouseContext.Deliveries
                .OrderBy(d => d.DeliveryDate)
                .Select(d => d.Goods)
                .FirstAsync();
        }

        // показать информацию о поставщике с наибольшим количеством товаров на складе
        public async Task<Supplier> GetSupplierWithMostAmountGoods()
        {
            var max = await _warehouseContext.Deliveries
                .GroupBy(p => p.SupplierId)
                .Select(p => new { SupplierId = p.Key, AmountSum = p.Sum(p => p.Amount) })
                .OrderByDescending(p => p.AmountSum)
                .FirstAsync();

            var supplier = await _warehouseContext.Suppliers
                .FindAsync(max.SupplierId);

            if (supplier != null)
            {
                return supplier;
            }
            throw new Exception("Нет товара");
        }

        // показать информацию о поставщике с наименьшим количеством товаров на складе
        public async Task<Supplier> GetSupplierWithFewestAmountGoods()
        {
            var min = await _warehouseContext.Deliveries
                .GroupBy(p => p.SupplierId)
                .Select(p => new { SupplierId = p.Key, AmountSum = p.Sum(p => p.Amount) })
                .OrderBy(p => p.AmountSum)
                .FirstAsync();

            var supplier = await _warehouseContext.Suppliers
                .FindAsync(min.SupplierId);

            if (supplier != null)
            {
                return supplier;
            }
            throw new Exception("Нет товара");
        }

        // показать информацию о типе товара с наибольшим количеством товаров на складе
        public async Task<GoodsType> GetGoodTypeWithMostAmountGoods()
        {
            var max = await _warehouseContext.Deliveries
                .GroupBy(p => p.Goods.GoodsTypeId)
                .Select(p => new { GoodsTypeId = p.Key, AmountSum = p.Sum(p => p.Amount) })
                .OrderByDescending(p => p.AmountSum)
                .FirstAsync();

            var goodsType = await _warehouseContext.GoodsType
                .FindAsync(max.GoodsTypeId);

            if (goodsType != null)
            {
                return goodsType;
            }
            throw new Exception("Нет товара");
        }

        // показать информацию о типе товара с наименьшим количеством товаров на складе
        public async Task<GoodsType> GetGoodTypeWithFewestAmountGoods()
        {
            var min = await _warehouseContext.Deliveries
                .GroupBy(p => p.Goods.GoodsTypeId)
                .Select(p => new { GoodsTypeId = p.Key, AmountSum = p.Sum(p => p.Amount) })
                .OrderBy(p => p.AmountSum)
                .FirstAsync();

            var goodsType = await _warehouseContext.GoodsType
                .FindAsync(min.GoodsTypeId);

            if (goodsType != null)
            {
                return goodsType;
            }
            throw new Exception("Нет товара");
        }

        // показать товары с поставки, которых прошло заданное количество дней
        public async Task<List<Good>> GoodsWithDaysOnWarehouse(int days)
        {
            var now = DateTime.Now;
            var timeNeeded = now.AddDays(-days);

            var deliveris = await _warehouseContext.Deliveries
                .Where(d => d.DeliveryDate <= timeNeeded)
                .ToListAsync();

            return deliveris
                .Select(d => d.Goods)
                .DistinctBy(g => g.Name)
                .ToList();
        }

        #endregion
    }
}
