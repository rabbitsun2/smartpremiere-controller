/*
 * Created Date: 2022-09-10 (Sat) Chuseok
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: IWarehouseBarcodeDAO
 * Filename: IWarehouseBarcodeDAO.cs
 * Description:
 * 
 */
using SmartLogistics.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.dao
{
    internal interface IWarehouseBarcodeDAO
    {
        DataSet SelectWarehouseBarcodeFindRandId(WarehouseBarcodeVO warehouseBarcodeVO);

    }
}
