using ReCapProject.Core.Utilites.Results.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface IColorService
    {
        IDataResult<Color> GetColorById(int id);
        IDataResult<List<Color>> GetAllColors();
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
