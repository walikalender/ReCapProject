using ReCapProject.Business.Abstract;
using ReCapProject.Business.Constants;
using ReCapProject.Business.ValidationRules.FluentValidation;
using ReCapProject.Core.CrossCuttingConcerns.Validation;
using ReCapProject.Core.Utilites.Results.Abstract;
using ReCapProject.Core.Utilites.Results.Concrete;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);

                _carDal.Add(car);
                return new SuccessResult(Message.CarAdded);
        }

        public IResult Delete(Car car)
        {
            if (DateTime.Now.Hour==20)
            {
                return new ErrorResult(Message.MaintenanceTime);
            }

            _carDal.Delete(car);
            return new SuccessResult(Message.CarDeleted);

        }

        public IDataResult<List<Car>> GetAllCars()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Message.MaintenanceTime);
            }

           return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Message.CarListed);

        }

        public IDataResult<Car> GetCarById(int id)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<Car>(Message.MaintenanceTime);
            }
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id),Message.CarGetted);
    
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Message.MaintenanceTime);
            }

            return new SuccessDataResult<List<CarDetailDto>>(_carDal.CarDetails(), Message.CarListed);
        }

        public IResult Update(Car car)
        {
            if (DateTime.Now.Hour==20)
            {
                return new ErrorResult(Message.MaintenanceTime);
            }

            _carDal.Update(car);
            return new SuccessResult(Message.CarUpdated);
        }
    }
}
