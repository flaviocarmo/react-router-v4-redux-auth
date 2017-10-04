using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using server.web_api.Filters;

namespace server.web_api.Controllers
{
	public class HomeController : ApiController
	{
		[JwtAuthentication]
		public string Get()
		{
			return "S3CR3T M3SS4G3";
		}
	}
}