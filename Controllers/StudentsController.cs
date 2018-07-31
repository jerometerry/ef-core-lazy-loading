using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using efLazyLoading.dal;
using efLazyLoading.dal.models;
using efLazyLoading.dto;

namespace efLazyLoading.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly DataAccessContext context;

        public StudentsController(DataAccessContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<StudentDTO>> GetAll()
        {
            return context.Students.Select(s => ToDTO(s)).ToList();
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public ActionResult<StudentDTO> GetById(long id)
        {
            var item = context.Students.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return ToDTO(item);
        }

        private StudentDTO ToDTO(Student student)
        {
            StudentDTO dto = new StudentDTO();
            dto.ID = student.ID;
            dto.LastName = student.LastName;
            dto.FirstMidName = student.FirstMidName;
            dto.EnrollmentDate = student.EnrollmentDate;
            return dto;
        }
    }
}
