using Microsoft.AspNetCore.Mvc;
using MyCar.DTO;
using MyCar.Servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace MyCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        readonly CarServies _CarServies;

        // GET: api/<BorrowController>
        [HttpGet]
        public Car Get()
        {
            return _CarServies.GetCar();
        }

        // GET api/<BorrowController>/5
        [HttpGet("{id}")]
        public Car Get(string id)
        {
            return _CarServies.GetCarById(id);
        }

        // POST api/<BorrowController>
        [HttpPost]
        public void Post([FromBody] Car car)
        {
             _CarServies.AddCar(car);
        }

        // PUT api/<BorrowController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Car car)
        {
             _CarServies.UpdateCarById(id, car);
        }

        // DELETE api/<BorrowController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _CarServies.DeleteCarById(id);
        }
    }
}
