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
    public class UplateController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Uplate
        public IQueryable<Uplate> GetUplate()
        {
            return db.Uplate;
        }

        // GET: api/Uplate/5
        [ResponseType(typeof(Uplate))]
        public IHttpActionResult GetUplate(int id)
        {
            Uplate uplate = db.Uplate.Find(id);
            if (uplate == null)
            {
                return NotFound();
            }

            return Ok(uplate);
        }

        // PUT: api/Uplate/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUplate(int id, Uplate uplate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uplate.Id)
            {
                return BadRequest();
            }

            db.Entry(uplate).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UplateExists(id))
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

        // POST: api/Uplate
        [ResponseType(typeof(Uplate))]
        public IHttpActionResult PostUplate(Uplate uplate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Uplate.Add(uplate);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = uplate.Id }, uplate);
        }

        // DELETE: api/Uplate/5
        [ResponseType(typeof(Uplate))]
        public IHttpActionResult DeleteUplate(int id)
        {
            Uplate uplate = db.Uplate.Find(id);
            if (uplate == null)
            {
                return NotFound();
            }

            db.Uplate.Remove(uplate);
            db.SaveChanges();

            return Ok(uplate);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UplateExists(int id)
        {
            return db.Uplate.Count(e => e.Id == id) > 0;
        }
    }
}