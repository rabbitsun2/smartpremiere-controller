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
    internal class ProductService : IProductService
    {
        private IProductDAO productDAO = new ProductDAO();

        public int InsertProduct(ProductVO productVO)
        {
            return productDAO.InsertProduct(productVO);
        }
        public int InsertProductImgDictionary(ProductImgDictionaryVO imgDictionaryVO)
        {
            return productDAO.InsertProductImgDictionary(imgDictionaryVO);
        }

        public int InsertProductBarcode(ProductBarcodeVO productBarcodeVO)
        {
            return productDAO.InsertProductBarcode(productBarcodeVO);
        }

        public ProductBarcodeVO SelectProductBarcodeFindId(ProductBarcodeVO productBarcodeVO)
        {
            return productDAO.SelectProductBarcodeFindId(productBarcodeVO);
        }


        public ProductVO SelectProductOne(ProductVO productVO)
        {
            return productDAO.SelectProductOne(productVO);
        }

        public ProductBarcodeVO SelectProductBarcodeFindRandId(ProductBarcodeVO productBarcodeVO)
        {
            return productDAO.SelectProductBarcodeFindRandId(productBarcodeVO);
        }

        public DataSet SelectProductImgUuid()
        {
            return productDAO.SelectProductImgUuid();
        }

        public DataSet SelectProductImgFindID(ProductImgUuidVO productImgUuidVO)
        {
            return productDAO.SelectProductImgFindID(productImgUuidVO);
        }

        public int DeleteProductImgUuid(ProductImgUuidVO productImgUuidVO)
        {
            return productDAO.DeleteProductImgUuid(productImgUuidVO);
        }

        public DataSet SelectDistinctImgDictFindProductId(ProductImgDictionaryVO productImgDictionaryVO)
        {
            return productDAO.SelectDistinctImgDictFindProductId(productImgDictionaryVO);
        }

        public DataSet SelectCountImgDictFindProductId(ProductImgDictionaryVO productImgDictionaryVO)
        {
            return productDAO.SelectCountImgDictFindProductId(productImgDictionaryVO);
        }

        public DataSet SelectProductFindID(ProductVO productVO)
        {
            return productDAO.SelectProductFindID(productVO);
        }

        public DataSet SelectProductBoxSpecFindProductID(ProductVO productVO)
        {
            return productDAO.SelectProductBoxSpecFindProductID(productVO);
        }

        public int InsertProductBoxSpec(ProductBoxSpecVO productBoxSpecVO)
        {
            return productDAO.InsertProductBoxSpec(productBoxSpecVO);
        }

    }

}
