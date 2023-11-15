using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public void TAdd(Product entity)
        {
            _ProductDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _ProductDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _ProductDal.GetAll().ToList();
        }

        public Product TGetId(int id)
        {
           return _ProductDal.GetId(id);
        }

        public void TUpdate(Product entity)
        {
            _ProductDal.Update(entity);

        }
    }
}
