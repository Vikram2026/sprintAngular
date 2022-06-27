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
    public class ProductController : ControllerBase
    {
        EcommerceDBContext db;
        public ProductController(EcommerceDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Tb1Product> GetProducts()
        {
            return db.Tb1Products;
        }


        [HttpPost]
        public string Post([FromBody] Tb1Product product)
        {
            Tb1Product s = new Tb1Product();
            s.Id = product.Id;
            s.ProductName = product.ProductName;
            s.ProductDescription = product.ProductDescription;
            s.CatId = product.CatId;
            s.ProductMrp = product.ProductMrp;
            s.ProductDiscount = product.ProductDiscount;
            s.ProductFinal = product.ProductFinal;
            s.ProductQuantity = product.ProductQuantity;
            db.Tb1Products.Add(s);
            db.SaveChanges();
            return "Success";
        }
    }
} 