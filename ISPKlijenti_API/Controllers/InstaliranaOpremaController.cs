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
using ISPKlijenti_API.Models;

namespace ISPKlijenti_API.Controllers
{
    public class InstaliranaOpremaController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/InstaliranaOprema
        public IQueryable<InstaliranaOprema> GetInstaliranaOprema()
        {
            return db.InstaliranaOprema;
        }

        [HttpGet]
        [ResponseType(typeof(List<isp_InstaliranaOprema_SelectyByKlijent_Result>))]
        [Route("api/InstaliranaOprema/GetInstaliranaOpremaByKlijent/{klijent?}")]
        public List<isp_InstaliranaOprema_SelectyByKlijent_Result> SearchByImePrezime(string klijent = "")
        {
            return db.isp_InstaliranaOprema_SelectyByKlijent(klijent).ToList();
        }

        // GET: api/InstaliranaOprema/5
        [ResponseType(typeof(InstaliranaOprema))]
        public IHttpActionResult GetInstaliranaOprema(int id)
        {
            InstaliranaOprema instaliranaOprema = db.InstaliranaOprema.Find(id);
            if (instaliranaOprema == null)
            {
                return NotFound();
            }

            return Ok(instaliranaOprema);
        }

        // PUT: api/InstaliranaOprema/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInstaliranaOprema(int id, InstaliranaOprema instaliranaOprema)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != instaliranaOprema.Id)
            {
                return BadRequest();
            }

            db.Entry(instaliranaOprema).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstaliranaOpremaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/InstaliranaOprema
        [ResponseType(typeof(InstaliranaOprema))]
        public IHttpActionResult PostInstaliranaOprema(InstaliranaOprema instaliranaOprema)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InstaliranaOprema.Add(instaliranaOprema);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = instaliranaOprema.Id }, instaliranaOprema);
        }

        // DELETE: api/InstaliranaOprema/5
        [ResponseType(typeof(InstaliranaOprema))]
        public IHttpActionResult DeleteInstaliranaOprema(int id)
        {
            InstaliranaOprema instaliranaOprema = db.InstaliranaOprema.Find(id);
            if (instaliranaOprema == null)
            {
                return NotFound();
            }

            db.InstaliranaOprema.Remove(instaliranaOprema);
            db.SaveChanges();

            return Ok(instaliranaOprema);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InstaliranaOpremaExists(int id)
        {
            return db.InstaliranaOprema.Count(e => e.Id == id) > 0;
        }
    }
}