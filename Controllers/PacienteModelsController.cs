using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using crudNetWeb.Models;

namespace crudNetWeb.Controllers
{
    public class PacienteModelsController : Controller
    {
        private Context db = new Context();

        // GET: PacienteModels
        public ActionResult Index()
        {
            return View(db.Pacientes.ToList());
        }

        // GET: PacienteModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PacienteModel pacienteModel = db.Pacientes.Find(id);
            if (pacienteModel == null)
            {
                return HttpNotFound();
            }
            return View(pacienteModel);
        }

        // GET: PacienteModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod,nome,sobrenome,endereco,bairro,cidade,uf,dataNasc,valorPlano")] PacienteModel pacienteModel)
        {
            if (ModelState.IsValid)
            {
                db.Pacientes.Add(pacienteModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pacienteModel);
        }

        // GET: PacienteModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PacienteModel pacienteModel = db.Pacientes.Find(id);
            if (pacienteModel == null)
            {
                return HttpNotFound();
            }
            return View(pacienteModel);
        }

        // POST: PacienteModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod,nome,sobrenome,endereco,bairro,cidade,uf,dataNasc,valorPlano")] PacienteModel pacienteModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pacienteModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pacienteModel);
        }

        // GET: PacienteModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PacienteModel pacienteModel = db.Pacientes.Find(id);
            if (pacienteModel == null)
            {
                return HttpNotFound();
            }
            return View(pacienteModel);
        }

        // POST: PacienteModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PacienteModel pacienteModel = db.Pacientes.Find(id);
            db.Pacientes.Remove(pacienteModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
