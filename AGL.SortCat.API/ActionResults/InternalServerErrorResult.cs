﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace AGL.SortCat.API.ActionResults
{
    public class InternalServerErrorResult : ErrorResult
    {
        public InternalServerErrorResult(HttpRequestMessage request, Error error)
            : base(request, error, HttpStatusCode.InternalServerError)
        {
        }
    }
}