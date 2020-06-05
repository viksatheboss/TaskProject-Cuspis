using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using TaskProject.Models;

namespace TaskProject.Controllers
{
    public class PeopleController : Controller
    {
        

        // GET: People
        public ActionResult Index(string search = "" )
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            ViewBag.search = search;
            List<People> people = _context.People.Where(temp => temp.FirstName.Contains(search)).ToList();
            return View();
        }

        public ActionResult Details(long id)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            People p = _context.People.Where(temp => temp.Id == id).FirstOrDefault();
            return View();

        }

        public ActionResult Create()
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            ViewBag.People = _context.People.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(People p)
        {

            ApplicationDbContext _context = new ApplicationDbContext();
            _context.People.Add(p);
            _context.SaveChanges();

            return RedirectToAction("Index");


        }


        public ActionResult Edit(int id)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            People people = _context.People.Where(temp => temp.Id == id).FirstOrDefault();
            return View(people);
        }

        [HttpPost]
        public ActionResult Edit(People p)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            People people = _context.People.Where(temp => temp.Id == p.Id).FirstOrDefault();
            people.FirstName = p.FirstName;
            people.LastName = p.LastName;
            people.MobileNumber = p.MobileNumber;
            people.Address = p.Address;
            people.Id = p.Id;


            _context.SaveChanges();
            return RedirectToAction("Index", "People");
        }

        public ActionResult Delete(int id)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            People people = _context.People.Where(temp => temp.Id == id).FirstOrDefault();
            return View(people);
        }
        public ActionResult Delete(int id, People p)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            People people = _context.People.Where(temp => temp.Id == id).FirstOrDefault();
            _context.People.Remove(people);
            _context.SaveChanges();
            return RedirectToAction("Index", "People");
        }
    }
}