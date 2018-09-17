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
    public class SkladisteController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Skladiste
        public IQueryable<Skladiste> GetSkladiste()
        {
            return db.Skladiste;
        }

        [HttpGet]
        [ResponseType(typeof(List<isp_Skladiste_SelectAll_Result>))]
        [Route("api/Skladiste/SelectAll")]
        public List<isp_Skladiste_SelectAll_Result> SelectAll()
        {
            return db.isp_Skladiste_SelectAll().ToList();
        }

        //GetSkladisteById
        [HttpGet]
        [ResponseType(typeof(isp_Skladiste_SelectAll_Result))]
        [Route("api/Skladiste/GetSkladisteById/{id}")]
        public isp_Skladiste_SelectAll_Result GetSkladisteById(int id)
        {
            isp_Skladiste_SelectAll_Result skladiste;
            skladiste = db.Skladiste.Where(x => x.Id == id).Select(s => new isp_Skladiste_SelectAll_Result
            {
                Id=s.Id,
                Cijena = s.OpremaMaterijal.Cijena,
                Kolicina = s.Kolicina,
                Lokacija = s.Lokacija,
                MjernaJedinica = s.OpremaMaterijal.MjerneJedinice.Oznaka,
                Naziv = s.OpremaMaterijal.Naziv
            }).SingleOrDefault();

            return skladiste;
        }

        [HttpGet]
        [ResponseType(typeof(Skladiste))]
        [Route("api/Skladiste/GetSkladisteByOpremaId/{opremaId}")]
        public IHttpActionResult GetSkladisteByOpremaId(int opremaId)
        {
            Skladiste skladiste = db.isp_Skladiste_SelectByOprema(opremaId).SingleOrDefault();
            if (skladiste != null)
            {
                return Ok(skladiste);
            }
            else
            {
                return NotFound();
            }
            
        }


        // GET: api/Skladiste/5
        [ResponseType(typeof(Skladiste))]
        public IHttpActionResult GetSkladiste(int id)
        {
            Skladiste skladiste = db.Skladiste.Find(id);
            if (skladiste == null)
            {
                return NotFound();
            }

            return Ok(skladiste);
        }

        // PUT: api/Skladiste/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSkladiste(int id, Skladiste skladiste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != skladiste.Id)
            {
                return BadRequest();
            }

            db.Entry(skladiste).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkladisteExists(id))
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

        // POST: api/Skladiste
        [ResponseType(typeof(Skladiste))]
        public IHttpActionResult PostSkladiste(Skladiste skladiste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Skladiste.Add(skladiste);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = skladiste.Id }, skladiste);
        }

        // DELETE: api/Skladiste/5
        [ResponseType(typeof(Skladiste))]
        public IHttpActionResult DeleteSkladiste(int id)
        {
            Skladiste skladiste = db.Skladiste.Find(id);
            if (skladiste == null)
            {
                return NotFound();
            }

            db.Skladiste.Remove(skladiste);
            db.SaveChanges();

            return Ok(skladiste);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SkladisteExists(int id)
        {
            return db.Skladiste.Count(e => e.Id == id) > 0;
        }
    }
}