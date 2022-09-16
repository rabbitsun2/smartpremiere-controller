/*
 * Created Date: 2022-07-19 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: MainFrm
 * Filename: MainFrm.cs
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

namespace SmartLogistics.service
{
    internal interface IProductService
    {
        int InsertProduct(ProductVO productVO);
        ProductVO SelectProductOne(ProductVO productVO);
        int InsertProductImgDictionary(ProductImgDictionaryVO imgDictionaryVO);
        int InsertProductBarcode(ProductBarcodeVO productBarcodeVO);
        ProductBarcodeVO SelectProductBarcodeFindId(ProductBarcodeVO productBarcodeVO);
        ProductBarcodeVO SelectProductBarcodeFindRandId(ProductBarcodeVO productBarcodeVO);
        DataSet SelectProductImgUuid();
        DataSet SelectProductImgFindID(ProductImgUuidVO productImgUuidVO);
        int DeleteProductImgUuid(ProductImgUuidVO productImgUuidVO);
        DataSet SelectDistinctImgDictFindProductId(ProductImgDictionaryVO productImgDictionaryVO);
        DataSet SelectCountImgDictFindProductId(ProductImgDictionaryVO productImgDictionaryVO);
        DataSet SelectProductFindID(ProductVO productVO);
        DataSet SelectProductBoxSpecFindProductID(ProductVO productVO);
        int InsertProductBoxSpec(ProductBoxSpecVO productBoxSpecVO);
    }
}
