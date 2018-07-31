using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using efLazyLoading.dal;
using efLazyLoading.dal.models;

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
        public ActionResult<List<Student>> GetAll()
        {
            return context.Students.ToList();
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public ActionResult<Student> GetById(long id)
        {
            var item = context.Students.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}