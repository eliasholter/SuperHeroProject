using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BariumDemo.Models;
using SuperHeroProject.Models;

namespace SuperHeroProject.Controllers
{
    public class HeroController : Controller
    {
        ApplicationDbContext db;

        public HeroController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Hero
        public ActionResult Index()
        {
            return View(db.Heroes.ToList());
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            Hero hero = new Hero();
            return View(hero);
        }

        // POST: Hero/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            try
            {
                // TODO: Add insert logic here
                db.Heroes.Add(hero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            Hero hero = db.Heroes.Where(h => h.Id == id).SingleOrDefault();
            return View(hero);
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Hero hero)
        {
            try
            {
                // TODO: Add update logic here
                Hero updatedHero = db.Heroes.Find(id);
                updatedHero.name = hero.name;
                updatedHero.alterEgo = hero.alterEgo;
                updatedHero.primaryAbility = hero.primaryAbility;
                updatedHero.secondaryAbility = hero.secondaryAbility;
                updatedHero.catchphrase = hero.catchphrase;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Hero hero)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
