using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        public Result(bool success, string message):this(success)//"this" burada Result classını kasteder.
            //:this(success)--> result ın tek parametreli constructor methoduna success i yolla.
        {
            Message = message;
        }

        public Result(bool success) //Overloading
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
