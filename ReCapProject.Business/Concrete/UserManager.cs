using ReCapProject.Business.Abstract;
using ReCapProject.Core.Utilites.Results.Abstract;
using ReCapProject.Core.Utilites.Results.Concrete;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.DataAccess.Concrete.EntityFramework;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            if (false)
            {
                return new ErrorResult();
            }

            _userDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User userd)
        {
            if (false)
            {
                return new ErrorResult();
            }

            _userDal.Delete(userd);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAllUsers()
        {
            if (false)
            {
                return new ErrorDataResult<List<User>>();
            }

            
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetUserById(int id)
        {
            if (false)
            {
                return new ErrorDataResult<User>();
            }   
            return new SuccessDataResult<User>(_userDal.Get(u=>u.Id==id));
        }

        public IResult Update(User user)
        {
            if (false)
            {
                return new ErrorResult();
            }

            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
