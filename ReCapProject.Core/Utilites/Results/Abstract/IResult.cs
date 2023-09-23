using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Core.Utilites.Results.Abstract
{
    public interface IResult
    {
        string Message { get; }
        bool Success { get; }
    }
}
