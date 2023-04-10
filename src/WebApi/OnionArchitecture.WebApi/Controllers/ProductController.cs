using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Interfaces.Repository;

namespace OnionArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allList = await productRepository.GetAllAsync();

            //wrong way
            var result = allList.Select(x => new ProductViewDto { Id = x.Id, Name = x.Name });

            return Ok(result);
        }
    }
}
