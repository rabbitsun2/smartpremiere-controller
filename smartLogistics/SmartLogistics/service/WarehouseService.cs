using SmartLogistics.dao;
using SmartLogistics.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.service
{
    internal class WarehouseService : IWarehouseService
    {
        private IWarehouseDAO warehouseDAO = new WarehouseDAO();

        public DataSet SelectWarehouseFindId(WarehouseVO warehouseVO)
        {
            return warehouseDAO.SelectWarehouseFindId(warehouseVO);
        }

        public DataSet SelectLatestWarehouseLogFindWid(WarehouseVO warehouseVO)
        {
            return warehouseDAO.SelectLatestWarehouseLogFindWid(warehouseVO);
        }

    }
}
