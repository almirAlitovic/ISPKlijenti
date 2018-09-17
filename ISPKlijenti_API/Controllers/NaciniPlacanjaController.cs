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
    public class NaciniPlacanjaController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/NaciniPlacanja
        public IQueryable<NaciniPlacanja> GetNaciniPlacanja()
        {
            return db.NaciniPlacanja;
        }

        // GET: api/NaciniPlacanja/5
        [ResponseType(typeof(NaciniPlacanja))]
        public IHttpActionResult GetNaciniPlacanja(int id)
        {
            NaciniPlacanja naciniPlacanja = db.NaciniPlacanja.Find(id);
            if (naciniPlacanja == null)
            {
                return NotFound();
            }

            return Ok(naciniPlacanja);
        }

        // PUT: api/NaciniPlacanja/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNaciniPlacanja(int id, NaciniPlacanja naciniPlacanja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != naciniPlacanja.Id)
            {
                return BadRequest();
            }

            db.Entry(naciniPlacanja).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NaciniPlacanjaExists(id))
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

        // POST: api/NaciniPlacanja
        [ResponseType(typeof(NaciniPlacanja))]
        public IHttpActionResult PostNaciniPlacanja(NaciniPlacanja naciniPlacanja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NaciniPlacanja.Add(naciniPlacanja);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = naciniPlacanja.Id }, naciniPlacanja);
        }

        // DELETE: api/NaciniPlacanja/5
        [ResponseType(typeof(NaciniPlacanja))]
        public IHttpActionResult DeleteNaciniPlacanja(int id)
        {
            NaciniPlacanja naciniPlacanja = db.NaciniPlacanja.Find(id);
            if (naciniPlacanja == null)
            {
                return NotFound();
            }

            db.NaciniPlacanja.Remove(naciniPlacanja);
            db.SaveChanges();

            return Ok(naciniPlacanja);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NaciniPlacanjaExists(int id)
        {
            return db.NaciniPlacanja.Count(e => e.Id == id) > 0;
        }
    }
}