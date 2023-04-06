﻿using SpryStore.BusinessLayer.Abstract;
using SpryStore.DataAccessLayer.Abstract;
using SpryStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStore.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetLast4Product()
        {
            return _productDal.GetLast4Product();
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public List<Product> TGetProductsListWithCategory()
        {
            return _productDal.GetProductsListWithCategory();
        }

        public void TInsert(Product t)
        {
            if (t.ProductName != "" && t.ProductName.Length >= 5 && t.ProductName.Length <= 20)
            {
                _productDal.Insert(t);
            }
            else
            {
                //Hata mesajı
            }
            
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
