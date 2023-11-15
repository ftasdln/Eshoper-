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
    public class SizeManager : ISizeService
    {
        ISizeDal _sizeDal;

        public SizeManager(ISizeDal sizeDal)
        {
            _sizeDal = sizeDal;
        }

        public void TAdd(Sizes entity)
        {
            _sizeDal.Add(entity);
        }

        public void TDelete(Sizes entity)
        {
            _sizeDal.Delete(entity);
        }

        public List<Sizes> TGetAll()
        {
            return _sizeDal.GetAll().ToList();
        }

        public Sizes TGetId(int id)
        {
            return _sizeDal.GetId(id);
        }

        public void TUpdate(Sizes entity)
        {
            _sizeDal.Update(entity);
        }
    }
}
