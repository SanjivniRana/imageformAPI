using imageform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace imageform.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FormController : ApiController
    {
        private FormContext db;
        public FormController()
        {
            db = new FormContext();
        }

        // GET: api/Form
        public IHttpActionResult Get()
        {
            FormContext db = new FormContext();
            var res = db.Forms.ToList();
            return Ok(res);
        }

        // POST: api/Home
        public IHttpActionResult PostNewStudent(Form form)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            db.Forms.Add(form);
            db.SaveChanges();
            return Ok();
        }
    }
}

