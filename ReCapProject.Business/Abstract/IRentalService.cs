using ReCapProject.Core.Utilites.Results.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IDataResult<Rental> GetRentalById(int id);
        IDataResult<List<Rental>> GetAllCars();
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
