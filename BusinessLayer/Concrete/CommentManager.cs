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
    public class CommentManager : ICommentService
    {
        ICommentsDal _commentsDal;

        public CommentManager(ICommentsDal commentsDal)
        {
            _commentsDal = commentsDal;
        }

        public void TAdd(Comments entity)
        {
            _commentsDal.Add(entity);
        }

        public void TDelete(Comments entity)
        {
            _commentsDal.Delete(entity);
        }

        public List<Comments> TGetAll()
        {
            return _commentsDal.GetAll ().ToList();
        }

        public Comments TGetId(int id)
        {
            return _commentsDal.GetId(id);
        }

        public void TUpdate(Comments entity)
        {
            _commentsDal.Update(entity);
        }
    }
}
