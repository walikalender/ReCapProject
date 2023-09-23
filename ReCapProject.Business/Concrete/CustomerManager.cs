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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            if (false)
            {
                return new ErrorResult();
            }

            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            if (false)
            {
                return new ErrorResult();
            }

            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAllCustomers()
        {
            if (false)
            {
                return new ErrorDataResult<List<Customer>>();
            }


            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetCustomerById(int id)
        {
            if (false)
            {
                return new ErrorDataResult<Customer>();
            }

            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == id));
        }

        public IResult Update(Customer customer)
        {
            if (false)
            {
                return new ErrorResult();
            }

            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
