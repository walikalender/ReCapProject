﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Core.Utilites.Results.Abstract
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
