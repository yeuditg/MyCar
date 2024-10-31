using Microsoft.AspNetCore.Mvc;
using MyCar.DTO;
using MyCar.Servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace MyCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowerController : ControllerBase
    {
        readonly BorrowServies _borrowSeries;

        // GET: api/<BorrowController>
        [HttpGet]
        public Borrowers Get()
        {
            return _borrowSeries.GetBorrower();
        }

        // GET api/<BorrowController>/5
        [HttpGet("{id}")]
        public Borrowers Get(string id)
        {
            return _borrowSeries.GetBorrowerById(id);
        }

        // POST api/<BorrowController>
        [HttpPost]
        public void Post([FromBody] Borrowers Borrowers)
        {
            _borrowSeries.AddBorrower(Borrowers);
        }

        // PUT api/<BorrowController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Borrowers borrowers)
        {
            _borrowSeries.UpdateBorrowerById(id, borrowers);
        }

        // DELETE api/<BorrowController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _borrowSeries.DeleteBorrowerById(id);
        }
    }
}
