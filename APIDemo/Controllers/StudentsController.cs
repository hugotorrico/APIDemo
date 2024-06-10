using APIDemo.Models;
using APIDemo.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;

namespace APIDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Insert(StudentRequestV1 request)
        {
            Student model = new Student();
            model.FirstName = request.FirstName;
            model.LastName = request.LastName;
            model.GradeID = request.GradeID;
            model.CreatedOn = DateTime.Now;

            _context.Students.Add(model);
            _context.SaveChanges();

        }

        [HttpGet]
        public List<Student> GetStudentsByName(string name)
        {
            var result = _context.Students.Where(x => x.FirstName == name).ToList();

            return result;

        }

        [HttpGet]
        public List<Student> GetStudentsByGrade(int gradeId)
        {
            var result = _context.Students
                    .Where(x => x.GradeID == gradeId)
                    .OrderBy(x => x.LastName)
                    .ToList();

            return result;

        }


    }
}
