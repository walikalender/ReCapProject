using ReCapProject.Core.Utilites.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Core.Utilites.Results.Concrete
{
    public class SuccessResult : Result, IResult
    {
        public SuccessResult(string message) : base(true, message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
