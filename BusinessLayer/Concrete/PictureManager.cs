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
    public class PictureManager : IPictureService
    {
        IPictureDal _pictureDal;

        public PictureManager(IPictureDal pictureDal)
        {
            _pictureDal = pictureDal;
        }

        public void TAdd(Pictures entity)
        {
            _pictureDal.Add(entity);
        }

        public void TDelete(Pictures entity)
        {
            _pictureDal.Delete(entity);
        }

        public List<Pictures> TGetAll()
        {
            return _pictureDal.GetAll().ToList();
        }

        public Pictures TGetId(int id)
        {
           return _pictureDal.GetId(id);
        }

        public void TUpdate(Pictures entity)
        {
            _pictureDal.Update(entity);
        }
    }
}
