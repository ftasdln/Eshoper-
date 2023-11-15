using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void TAdd(Colors entity)
        {
           _colorDal.Add(entity);
        }

        public void TDelete(Colors entity)
        {
            _colorDal.Delete(entity);
        }

        public List<Colors> TGetAll()
        {
            return _colorDal.GetAll().ToList();
        }

        public Colors TGetId(int id)
        {
            return _colorDal.GetId(id);
        }

        public void TUpdate(Colors entity)
        {
            _colorDal.Update(entity);
        }
    }
}
