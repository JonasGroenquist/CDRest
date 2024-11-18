using CDRest.Model;
using CDRest.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CDRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly RecordRepo _repository;
        public RecordController(RecordRepo repository)
        {
            _repository = repository;
        }
        // GET: api/<RecordCtrlr>
        [HttpGet]
        public ActionResult <IEnumerable<Record>> Get()
        {
            try
            {
                var records = _repository.GetAll();
                if (records == null || !records.Any())
                {
                    return NotFound("No records found");
                }
                return Ok(records);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        // GET api/<RecordCtrlr>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RecordCtrlr>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecordCtrlr>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecordCtrlr>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
