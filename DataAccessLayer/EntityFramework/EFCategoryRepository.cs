using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        ICategoryDal _categoryDal;

        public EFCategoryRepository()
        {
        }

        public void TGetId(int id)
        {
            _categoryDal.GetId(id);
        }
    }
}
