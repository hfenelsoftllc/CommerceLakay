using CommerceLakay.Model;
using CommerceLakay.Model.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommerceLakay.ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(ProductDbContext DbContext) : ControllerBase
    {
        [HttpGet]
        public async  Task<List<ProductModel>> GetProduct()
        {
            return await DbContext.Products.ToListAsync();
        }
    }
}
