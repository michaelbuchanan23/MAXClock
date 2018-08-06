using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MAXClockAPI.Models;
using MAXClockAPI.Utilities;

namespace MAXClockAPI.Controllers
{
    public class ClassesController : ApiController
    {
        private MAXClockAPIContext db = new MAXClockAPIContext();

        [HttpGet]
		[ActionName("List")]
		public JSONResponse ListClasses() {

			return new JSONResponse() {
				Data = db.Classes.ToList()
			};
		}

		[HttpGet]
		[ActionName("Get")]
		public JSONResponse GetClass(int id) {

			return new JSONResponse();
		}

		[HttpPost]
		[ActionName("Create")]
		public JSONResponse CreateClass(Class @class) {

			return new JSONResponse();
		}

		[HttpPost]
		[ActionName("Delete")]
		public JSONResponse DeleteClass(int id) {

			return new JSONResponse();
		}


    }
}