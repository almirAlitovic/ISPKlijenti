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
    public class UslugeController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Usluge
        public IQueryable<Usluge> GetUsluge()
        {
            return db.Usluge;
        }

        // GET: api/Usluge/5
        [ResponseType(typeof(Usluge))]
        public IHttpActionResult GetUsluge(int id)
        {
            Usluge usluge = db.Usluge.Find(id);
            if (usluge == null)
            {
                return NotFound();
            }

            return Ok(usluge);
        }

        // PUT: api/Usluge/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsluge(int id, Usluge usluge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usluge.Id)
            {
                return BadRequest();
            }

            db.Entry(usluge).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UslugeExists(id))
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

        // POST: api/Usluge
        [ResponseType(typeof(Usluge))]
        public IHttpActionResult PostUsluge(Usluge usluge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Usluge.Add(usluge);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = usluge.Id }, usluge);
        }

        // DELETE: api/Usluge/5
        [ResponseType(typeof(Usluge))]
        public IHttpActionResult DeleteUsluge(int id)
        {
            Usluge usluge = db.Usluge.Find(id);
            if (usluge == null)
            {
                return NotFound();
            }

            db.Usluge.Remove(usluge);
            db.SaveChanges();

            return Ok(usluge);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UslugeExists(int id)
        {
            return db.Usluge.Count(e => e.Id == id) > 0;
        }
    }
}