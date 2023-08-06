using DotNetAssignment.Classes;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAssignment.Controllers
{
    [Route("api/[controller]")]
    public class TriangleController : Controller
    {
        [HttpPost]
        public string Post([FromBody]TriangleClass triangle)
        {
            if (triangle.IsRightTriangle(triangle))//check if the triangle is a right triangle or not
            {
                return "Yes, this is a right triangle";
            }
            else
            {
                return "No, this is not a right triangle";
            }
        }
    }
}

