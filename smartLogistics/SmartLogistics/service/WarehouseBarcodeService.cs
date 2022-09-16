/*
 * Created Date: 2022-09-10 (Sat) Chuseok
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: WarehouseBarcodeService
 * Filename: WarehouseBarcodeService.cs
 * Description:
 * 
 */
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
    internal class WarehouseBarcodeService : IWarehouseBarcodeService
    {
        private IWarehouseBarcodeDAO warehouseBarcodeDAO = new WarehouseBarcodeDAO();

        public DataSet SelectWarehouseBarcodeFindRandId(WarehouseBarcodeVO warehouseBarcodeVO)
        {
            return warehouseBarcodeDAO.SelectWarehouseBarcodeFindRandId(warehouseBarcodeVO);
        }

    }
}
