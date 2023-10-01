using Microsoft.AspNetCore.Mvc;
using Jazani.Domain.Admins.Repositories;
using Jazani.Domain.Admins.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jazani.Api.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IOfficeRepository officeRepository;

        public OfficeController(IOfficeRepository officeRepository)
        {
            this.officeRepository = officeRepository;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<Office>> Get()
        {
            return await this.officeRepository.FindAllAsync();
        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<Office> Get(int id)
        {
            return await this.officeRepository.FindByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
