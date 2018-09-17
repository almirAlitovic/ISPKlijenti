﻿using System;
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
    public class UlogeController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Uloge
        public IQueryable<Uloge> GetUloge()
        {
            return db.Uloge;
        }

        // GET: api/Uloge/5
        [ResponseType(typeof(Uloge))]
        public IHttpActionResult GetUloge(int id)
        {
            Uloge uloge = db.Uloge.Find(id);
            if (uloge == null)
            {
                return NotFound();
            }

            return Ok(uloge);
        }

        // PUT: api/Uloge/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUloge(int id, Uloge uloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uloge.Id)
            {
                return BadRequest();
            }

            db.Entry(uloge).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlogeExists(id))
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

        // POST: api/Uloge
        [ResponseType(typeof(Uloge))]
        public IHttpActionResult PostUloge(Uloge uloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Uloge.Add(uloge);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = uloge.Id }, uloge);
        }

        // DELETE: api/Uloge/5
        [ResponseType(typeof(Uloge))]
        public IHttpActionResult DeleteUloge(int id)
        {
            Uloge uloge = db.Uloge.Find(id);
            if (uloge == null)
            {
                return NotFound();
            }

            db.Uloge.Remove(uloge);
            db.SaveChanges();

            return Ok(uloge);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UlogeExists(int id)
        {
            return db.Uloge.Count(e => e.Id == id) > 0;
        }
    }
}