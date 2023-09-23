using ReCapProject.Business.Abstract;
using ReCapProject.Business.Constants;
using ReCapProject.Core.Utilites.Results.Abstract;
using ReCapProject.Core.Utilites.Results.Concrete;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Message.BrandNameInvalid);
            }

            _brandDal.Add(brand);
            return new SuccessResult(Message.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorResult(Message.MaintenanceTime);
            }

            _brandDal.Delete(brand);
            return new SuccessResult(Message.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAllBrands()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Brand> GetBrandById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Brand brand)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorResult(Message.MaintenanceTime);
            }

            _brandDal.Update(brand);
            return new SuccessResult(Message.BrandUpdated);
        }
    }
}
