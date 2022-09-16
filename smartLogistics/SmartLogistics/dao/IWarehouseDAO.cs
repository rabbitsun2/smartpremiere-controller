using SmartLogistics.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.dao
{
    internal interface IWarehouseDAO
    {
        DataSet SelectWarehouseFindId(WarehouseVO warehouseVO);
        DataSet SelectLatestWarehouseLogFindWid(WarehouseVO warehouseVO);
    }

}
