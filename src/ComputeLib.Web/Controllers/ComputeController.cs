using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComputeLib.Web.Controllers
{


    [Route("api/[controller]")]
    public class ComputeController : Controller
    {
        private readonly INumCompute _numCompute;

        public ComputeController(INumCompute numCompute)
        {
            _numCompute = numCompute;
        }


        // GET api/values
        [HttpPost("add")]
        public int Add([FromBody]int[] nums)
        {
            return _numCompute.ComputeAdd(nums);
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
