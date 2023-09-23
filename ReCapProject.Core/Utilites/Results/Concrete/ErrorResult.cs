using ReCapProject.Core.Utilites.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Core.Utilites.Results.Concrete
{
    public class ErrorResult:Result,IResult
    {
        public ErrorResult(string message):base(false,message)
        {
            
        }
        public ErrorResult() : base(false)
        {

        }
    }
}
