using ReCapProject.Core.Utilites.Results.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<Brand> GetBrandById(int id);
        IDataResult<List<Brand>> GetAllBrands();
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
    }
}
