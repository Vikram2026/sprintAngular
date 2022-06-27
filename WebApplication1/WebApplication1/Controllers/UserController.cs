using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        EcommerceDBContext db;
        public UserController(EcommerceDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Tb1Product> GetProducts()
        {
            return db.Tb1Products;
        }


    }
}
