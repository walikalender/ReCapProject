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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Message.ColorNameInvalid);
            }

            _colorDal.Add(color);
            return new SuccessResult(Message.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorResult(Message.MaintenanceTime);
            }

            _colorDal.Delete(color);
            return new SuccessResult(Message.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAllColors()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Color> GetColorById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Color color)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorResult(Message.MaintenanceTime);
            }

            _colorDal.Update(color);
            return new SuccessResult(Message.ColorrUpdated);
        }
    }
}
