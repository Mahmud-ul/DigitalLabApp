using DigitalLabApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLabApp.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly DigitalLabContext _db;
        public InvoiceController(DigitalLabContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ICollection<Invoice> invoices =_db.Invoices.ToList();
            return View(invoices);
        }

        [HttpGet]
        public ActionResult<> CreateOrder()
        {

        }
    }
}
