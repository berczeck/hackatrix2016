using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Api
{
    public class HomeController : ApiController
    {
        public string GetVersion()
        {
            return "1.1.0";
        }
    }
}
