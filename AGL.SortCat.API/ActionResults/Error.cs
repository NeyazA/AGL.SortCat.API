using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGL.SortCat.API.ActionResults
{
    public class Error
    { 
        public Error(string message) : this(message, null)
        {
        }
        public Error(string message, InternalError internalError)
        {
            Message = message;
            InternalError = internalError;
        }

        public string Message { get; }

        public InternalError InternalError { get; }
    }

    public class InternalError
    {
        public string ErrorId { get; set; }
        public string ErrorNumber { get; set; }
        public string Description { get; set; }
    }
}