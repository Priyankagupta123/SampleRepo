using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AzureAssignment1.Controllers
{
    public class ProductsController : Controller
    {
        private string _dbConnectionString;
        public IActionResult Index()
        {
            return null;
        }
    }
}