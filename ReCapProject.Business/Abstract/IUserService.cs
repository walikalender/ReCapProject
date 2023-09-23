using ReCapProject.Core.Utilites.Results.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetUserById(int id);
        IDataResult<List<User>> GetAllUsers();
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
