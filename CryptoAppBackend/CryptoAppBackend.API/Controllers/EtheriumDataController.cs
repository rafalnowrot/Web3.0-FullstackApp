using CryptoAppBackend.Services.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CryptoAppBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtheriumDataController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EtheriumDataController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<EtheriumDataController>
        [HttpGet]
        public async Task<List<Services.EtheriumData>> Get()
        {
            return await _mediator.Send(new GetEtheriumDataList());
        }

        // GET api/<EtheriumDataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EtheriumDataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EtheriumDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EtheriumDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
