using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExerciseWebApp.Models;
using ExerciseWebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExerciseWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Exercise")]
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService = null;

        public ExerciseController() {
            _exerciseService = new ExerciseService();
        }

        // GET: api/Exercise
        [HttpGet]
        public IEnumerable<Image> Get()
        {
            return _exerciseService.GetImages();
        }

        // GET: api/Exercise/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Exercise
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Exercise/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
