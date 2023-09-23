using ReCapProject.Core.DataAccess.Concrete;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.DataAccess.Concrete.Context;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;


namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCap>, ICarDal
    {
        public List<CarDetailDto> CarDetails()
        {
            using (ReCap context = new ReCap())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join k in context.Colors
                             on c.ColorId equals k.ColorId
                             select new CarDetailDto
                             {
                                  CarName = c.CarName,
                                  BrandName = b.BrandName,
                                  ColorName = k.ColorName,
                                  DailyPrice=c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
