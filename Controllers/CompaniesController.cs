using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskProject.Models;

namespace TaskProject.Controllers
{
    public class CompaniesController : Controller
    {
        
        // GET: Companies
        public ActionResult Index(string search = "")
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            ViewBag.search = search;
            List<Company> companies = _context.Companies.Where(temp => temp.CompanyName.Contains(search)).ToList();
            
            return View();
        }

        public ActionResult Details(long id)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            Company c = _context.Companies.Where(temp => temp.Id == id).FirstOrDefault();
            return View();

        }

        public ActionResult Create()
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            ViewBag.Companies = _context.Companies.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Company c)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            _context.Companies.Add(c);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult Edit(int id)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            Company company = _context.Companies.Where(temp => temp.Id == id).FirstOrDefault();
            return View(company);
        }

        [HttpPost]
        public ActionResult Edit(Company c)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            Company company = _context.Companies.Where(temp => temp.Id == c.Id).FirstOrDefault();
            company.CompanyName = c.CompanyName;
            company.ContactNumber = c.ContactNumber;
            company.Address = c.Address;
            company.Id = c.Id;
            

            _context.SaveChanges();
            return RedirectToAction("Index", "Companies");
        }

        public ActionResult Delete(int id)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            Company company = _context.Companies.Where(temp => temp.Id == id).FirstOrDefault();
            return View(company);
        }
        public ActionResult Delete(int id, Company c)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            Company existingVehicle = _context.Companies.Where(temp => temp.Id == id).FirstOrDefault();
            _context.Companies.Remove(existingVehicle);
            _context.SaveChanges();
            return RedirectToAction("Index", "Companies");
        }


    }
}