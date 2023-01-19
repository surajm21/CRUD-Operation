﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebApplication1.Models;
using System.Data.Entity;
using System.Data.Entity;


namespace DemoWebApplication1.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        testEntities db = new testEntities();
        public ActionResult Index()
        {
            List<student> lst = db.students.ToList();
            return View(lst);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(student s)
        {
            db.students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            student st = db.students.Find(id);
            return View(st);
        }
        [HttpPost]
        public ActionResult Edit(student s)
        {
            db.Entry<student>(s).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            student st = db.students.Find(id);
            db.students.Remove(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}