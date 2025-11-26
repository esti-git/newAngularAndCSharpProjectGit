using Dto; // מניח ש-DtoCategory מוגדר כאן עם Id ו-Name ב-PascalCase
using IBll;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // ה-Controller הזה יטפל בבקשות ל- /api/Category
    public class CategoryController : ControllerBase
    {
        private readonly IBll.BllInterface _bll;

        public CategoryController(IBll.BllInterface bll)
        {
            this._bll = bll;
        }

        [HttpGet]
        public async Task<ActionResult<List<DtoCategory>>> GetCategories()
        {
            // קריאה ל-BLL
            var categories = await _bll.GetAllCategories();

            if (categories == null || !categories.Any())
            {
                return NoContent(); // 204
            }

            return Ok(categories); // 200 עם הנתונים
        }
    }
}