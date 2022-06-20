using Microsoft.AspNetCore.Mvc;

namespace Alsoft.Recruitment.FoodStore.Abstractions
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class ModuleController : ControllerBase
    {
        protected ModuleController()
        {
        }
    }
}
