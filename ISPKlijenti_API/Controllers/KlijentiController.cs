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
    public class KlijentiController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Klijenti
        public IQueryable<Klijenti> GetKlijenti()
        {
            return db.Klijenti;
        }

        // GET: api/Klijenti/5
        [ResponseType(typeof(Klijenti))]
        public IHttpActionResult GetKlijenti(int id)
        {
            Klijenti klijenti = db.Klijenti.Find(id);
            if (klijenti == null)
            {
                return NotFound();
            }

            return Ok(klijenti);
        }

        [HttpGet]
        [ResponseType(typeof(List<Klijenti>))]
        [Route("api/Klijenti/SearchByImePrezime/{imePrezime?}")]
        public List<Klijenti> SearchByImePrezime(string imePrezime = "")
        {
            return db.isp_Klijenti_SelectByImePrezime(imePrezime).ToList();
        }

        [HttpGet]
        [ResponseType(typeof(Klijenti))]
        [Route("api/Klijenti/GetLastKlijent")]
        public IHttpActionResult GetLastKlijent()
        {
            return Ok(db.Klijenti.OrderByDescending(x=>x.Id).FirstOrDefault());
        }

        // PUT: api/Klijenti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKlijenti(int id, Klijenti klijenti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != klijenti.Id)
            {
                return BadRequest();
            }

            db.Entry(klijenti).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KlijentiExists(id))
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

        // POST: api/Klijenti
        [ResponseType(typeof(Klijenti))]
        public IHttpActionResult PostKlijenti(Klijenti klijenti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //db.Klijenti.Add(klijenti);
            //db.SaveChanges();

            try
            {
                klijenti.Id = Convert.ToInt32(db.isp_Klijenti_Insert(klijenti.Ime, klijenti.Prezime, klijenti.KorisnickoIme,
                    klijenti.Email, klijenti.Adresa, klijenti.Telefon, klijenti.Aktivan).FirstOrDefault());

            }
            catch (Exception)
            {

                throw;
            }

            return CreatedAtRoute("DefaultApi", new { id = klijenti.Id }, klijenti);
        }

        // DELETE: api/Klijenti/5
        [ResponseType(typeof(Klijenti))]
        public IHttpActionResult DeleteKlijenti(int id)
        {
            Klijenti klijenti = db.Klijenti.Find(id);
            if (klijenti == null)
            {
                return NotFound();
            }

            db.Klijenti.Remove(klijenti);
            db.SaveChanges();

            return Ok(klijenti);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KlijentiExists(int id)
        {
            return db.Klijenti.Count(e => e.Id == id) > 0;
        }
    }
}