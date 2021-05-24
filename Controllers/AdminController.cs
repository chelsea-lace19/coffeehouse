using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using Lab11._2.Models;


namespace Lab11._2.Controllers
{
    public class AdminController : Controller
    {
        static MySqlConnection dab = new MySqlConnection("Server=127.0.0.1;Database=coffeehouse;Uid=root;Password=abc123");

        public IActionResult Index()
        {
            List<Product> prod = dab.GetAll<Product>().ToList();
            return View(prod);
        }
        public IActionResult EditForm(int id)
        {
            Product prod = dab.Get<Product>(id);
            return View(prod);
        }
        public IActionResult Delete(int id)
        {
            Product prod = dab.Get<Product>(id);
            dab.Delete(prod);
            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {
            return View();
        }

        public IActionResult Add(Product prod)
        {
            dab.Insert(prod);
            return RedirectToAction("Index");
        }
    }
}
