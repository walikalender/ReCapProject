using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCapProject.Business.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
                _brandService = brandService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAllBrands();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetBrandById(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        
        [HttpPut]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

       

        [HttpDelete("deleteid")]
        public IActionResult Delete(int id)
        {
            var result = _brandService.Delete(_brandService.GetBrandById(id).Data);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        /*
       [HttpDelete("delete")]
       public IActionResult Delete(Car car)
       {
           var result = _carService.Delete(car);

           if (result.Success)
           {
               return Ok(result);
           }
           return BadRequest(result.Message);
       }
       */
    }
}
