using ReCapProject.Business.Abstract;
using ReCapProject.Business.Constants;
using ReCapProject.Core.Utilites.Results.Abstract;
using ReCapProject.Core.Utilites.Results.Concrete;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Delete(Rental rental)
        {
            if (false)
            {
                return new ErrorResult();
            }

            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAllCars()
        {
            if (false)
            {
                return new ErrorDataResult<List<Rental>>();
            }


            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetRentalById(int id)
        {
            if (false)
            {
                return new ErrorDataResult<Rental>();
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == id));
        }

        public IResult Add(Rental rental)
        {
            if (rental.IsReturned == false)
            {
                return new ErrorResult(Message.NotReturnedCar);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Message.ReturnedCar);
        }

        public IResult Update(Rental rental)
        {
            if (false)
            {
                return new ErrorResult();
            }

            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
