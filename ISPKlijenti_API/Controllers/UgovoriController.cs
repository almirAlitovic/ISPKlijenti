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
    public class UgovoriController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Ugovori
        public IQueryable<Ugovori> GetUgovori()
        {
            return db.Ugovori;
        }

        // GET: api/Ugovori/5
        [ResponseType(typeof(Ugovori))]
        public IHttpActionResult GetUgovori(int id)
        {
            Ugovori ugovori = db.Ugovori.Find(id);
            if (ugovori == null)
            {
                return NotFound();
            }

            return Ok(ugovori);
        }

        [HttpGet]
        [ResponseType(typeof(isp_Ugovori_Index))]
        [Route("api/Ugovori/GetUgovoriByKlijent/{imePrezime?}")]
        public IHttpActionResult GetUgovoriByKlijent(string imePrezime = "")
        {
            return Ok(db.isp_Ugovori_SelectByKlijent(imePrezime));
        }

        [HttpGet]
        [ResponseType(typeof(Ugovori))]
        [Route("api/Ugovori/GetUgovoriByKlijentId/{klijentId?}")]
        public IHttpActionResult GetUgovoriByKlijentId(int klijentId)
        {
            return Ok(db.Ugovori.Where(u => u.KlijentId == klijentId).SingleOrDefault());
        }

        [HttpGet]
        [ResponseType(typeof(isp_Ugovori_Index))]
        [Route("api/Ugovori/GetUgovoriByBrojUgovora/{brojUgovora?}")]
        public IHttpActionResult GetUgovoriByBrojUgovora(int brojUgovora = 0)
        {
            return Ok(db.isp_Ugovori_SelectByBrojUgovora(brojUgovora));
        }

        // PUT: api/Ugovori/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUgovori(int id, Ugovori ugovori)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ugovori.Id)
            {
                return BadRequest();
            }

            db.Entry(ugovori).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UgovoriExists(id))
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

        // POST: api/Ugovori
        [ResponseType(typeof(Ugovori))]
        public IHttpActionResult PostUgovori(Ugovori ugovori)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ugovori.Add(ugovori);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ugovori.Id }, ugovori);
        }

        // DELETE: api/Ugovori/5
        [ResponseType(typeof(Ugovori))]
        public IHttpActionResult DeleteUgovori(int id)
        {
            Ugovori ugovori = db.Ugovori.Find(id);
            if (ugovori == null)
            {
                return NotFound();
            }

            db.Ugovori.Remove(ugovori);
            db.SaveChanges();

            return Ok(ugovori);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UgovoriExists(int id)
        {
            return db.Ugovori.Count(e => e.Id == id) > 0;
        }
    }
}