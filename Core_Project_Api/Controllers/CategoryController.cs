using Core_Project_Api.DAL.ApiContext;
using Core_Project_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategoryList()
        {
            var c = new Context();
            return Ok(c.categories.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var c = new Context();
            var value = c.categories.Find(id);
            if (value==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            var c = new Context();
            c.Add(category);
            c.SaveChanges();
            return Created("",category);
        }
        [HttpPut]
        public IActionResult EditCategory(Category category)
        {
            var c = new Context();
            var value = c.Find<Category>(category.CategoryId);
            if (value==null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = category.CategoryName;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id) 
        {
            using var c = new Context();
            var value = c.categories.Find(id);
            if (value==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        
    }
}
