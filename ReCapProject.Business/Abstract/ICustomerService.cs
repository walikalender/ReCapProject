using ReCapProject.Core.Utilites.Results.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetCustomerById(int id);
        IDataResult<List<Customer>> GetAllCustomers();
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
    }
}
