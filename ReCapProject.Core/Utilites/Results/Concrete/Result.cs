using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Utilites.Results.Abstract;

namespace ReCapProject.Core.Utilites.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public string Message { get; }

        public bool Success { get; }
    }
}
