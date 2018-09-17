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
    public class NabavkaController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Nabavka
        public IQueryable<Nabavka> GetNabavka()
        {
            return db.Nabavka;
        }

        // GET: api/Nabavka/5
        [ResponseType(typeof(Nabavka))]
        public IHttpActionResult GetNabavka(int id)
        {
            Nabavka nabavka = db.Nabavka.Find(id);
            if (nabavka == null)
            {
                return NotFound();
            }

            return Ok(nabavka);
        }

        [HttpGet]
        [ResponseType(typeof(List<isp_Nabavka_SelectById_Result>))]
        [Route("api/Nabavka/GetNabavkaById/{id?}")]
        public IHttpActionResult GetNabavkaById(int id = 0)
        {
            List< isp_Nabavka_SelectById_Result> nabavke = db.isp_Nabavka_SelectById(id).ToList();
            if (nabavke == null)
            {
                return NotFound();
            }

            return Ok(nabavke);
        }

        //GetNabavkaByDatum
        [HttpGet]
        [ResponseType(typeof(List<isp_Nabavka_SelectByDatum_Result>))]
        [Route("api/Nabavka/GetNabavkaByDatum/{datum1?}/{datum2?}")]
        public IHttpActionResult GetNabavkaByDatum(DateTime datum1, DateTime datum2)
        {
            List<isp_Nabavka_SelectByDatum_Result> nabavke = db.isp_Nabavka_SelectByDatum(datum1, datum2).ToList();
            if (nabavke == null)
            {
                return NotFound();
            }

            return Ok(nabavke);
        }


        // PUT: api/Nabavka/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNabavka(int id, Nabavka nabavka)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nabavka.Id)
            {
                return BadRequest();
            }

            db.Entry(nabavka).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NabavkaExists(id))
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

        // POST: api/Nabavka
        [ResponseType(typeof(Nabavka))]
        public IHttpActionResult PostNabavka(Nabavka nabavka)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Nabavka.Add(nabavka);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = nabavka.Id }, nabavka);
        }

        // DELETE: api/Nabavka/5
        [ResponseType(typeof(Nabavka))]
        public IHttpActionResult DeleteNabavka(int id)
        {
            Nabavka nabavka = db.Nabavka.Find(id);
            if (nabavka == null)
            {
                return NotFound();
            }

            db.Nabavka.Remove(nabavka);
            db.SaveChanges();

            return Ok(nabavka);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NabavkaExists(int id)
        {
            return db.Nabavka.Count(e => e.Id == id) > 0;
        }
    }
}