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
    public class ZaposleniciController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Zaposlenici
        public IQueryable<Zaposlenici> GetZaposlenici()
        {
            return db.Zaposlenici;
        }

        // GET: api/Zaposlenici/5
        [ResponseType(typeof(Zaposlenici))]
        [Route("api/Zaposlenici/GetZaposlenikByUsername/{username}")]
        public IHttpActionResult GetZaposlenikByUsername(string username)
        {
            Zaposlenici zaposlenik = db.Zaposlenici.Where(x=>x.KorisnickoIme == username).FirstOrDefault();
            if (zaposlenik == null)
            {
                return NotFound();
            }

            return Ok(zaposlenik);
        }

        [ResponseType(typeof(Zaposlenici))]
        public IHttpActionResult GetZaposlenici(int id)
        {
            Zaposlenici zaposlenici = db.Zaposlenici.Find(id);
            if (zaposlenici == null)
            {
                return NotFound();
            }

            return Ok(zaposlenici);
        }

        [HttpGet]
        [ResponseType(typeof(Zaposlenici))]
        [Route("api/Zaposlenici/SearchByImePrezime/{imePrezime?}")]
        public List<Zaposlenici> SearchByImePrezime(string imePrezime = "")
        {
            return db.isp_Zaposlenici_SelectByImePrezime(imePrezime).ToList();
        }

        // PUT: api/Zaposlenici/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutZaposlenici(int id, Zaposlenici zaposlenici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zaposlenici.Id)
            {
                return BadRequest();
            }

            db.Entry(zaposlenici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZaposleniciExists(id))
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

        // POST: api/Zaposlenici
        [ResponseType(typeof(Zaposlenici))]
        public IHttpActionResult PostZaposlenici(Zaposlenici zaposlenici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Zaposlenici.Add(zaposlenici);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zaposlenici.Id }, zaposlenici);
        }

        // DELETE: api/Zaposlenici/5
        [ResponseType(typeof(Zaposlenici))]
        public IHttpActionResult DeleteZaposlenici(int id)
        {
            Zaposlenici zaposlenici = db.Zaposlenici.Find(id);
            if (zaposlenici == null)
            {
                return NotFound();
            }

            db.Zaposlenici.Remove(zaposlenici);
            db.SaveChanges();

            return Ok(zaposlenici);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ZaposleniciExists(int id)
        {
            return db.Zaposlenici.Count(e => e.Id == id) > 0;
        }
    }
}