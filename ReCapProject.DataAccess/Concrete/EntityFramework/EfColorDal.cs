using ReCapProject.Core.DataAccess.Concrete;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.DataAccess.Concrete.Context;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Color = ReCapProject.Entities.Concrete.Color;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCap>, IColorDal
    {
    }
}
