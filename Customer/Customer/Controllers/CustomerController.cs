using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Customer.Models;

namespace Customer.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class CustomerController : Controller
	{
		private readonly ICustomerRepository _CustomerRepository;

		public CustomerController(ICustomerRepository CustomerRepository)
		{
			_CustomerRepository = CustomerRepository;
		}

		[HttpGet]
		[Produces("application/json", Type = typeof(IEnumerable<CustomerItem>))]
		public IEnumerable<CustomerItem> GetAll()
		{
			return _CustomerRepository.GetAll();
		}
		[Produces("application/json", Type = typeof(IEnumerable<CustomerItem>))]
		[HttpGet("{id}", Name = "GetCustomer")]
		public IActionResult GetById(long id)
		{
			var item = _CustomerRepository.Find(id);
			if (item == null)
			{
				return NotFound();
			}
			return new ObjectResult(item);
		}

		[HttpPost]
		[ProducesResponseType(typeof(CustomerItem), 201)]
		[ProducesResponseType(typeof(CustomerItem), 400)]
		public IActionResult Create([FromBody] CustomerItem item)
		{
			if (item == null)
			{
				return BadRequest();
			}

			_CustomerRepository.Add(item);

			return CreatedAtRoute("GetCustomer", new { id = item.Key }, item);
		}
		[Produces("application/json", Type = typeof(IEnumerable<CustomerItem>))]
		[HttpPut("{id}")]
		public IActionResult Update(long id, [FromBody] CustomerItem item)
		{
			if (item == null || item.Key != id)
			{
				return BadRequest();
			}

			var Customer = _CustomerRepository.Find(id);
			if (Customer == null)
			{
				return NotFound();
			}

			Customer.IsComplete = item.IsComplete;
			Customer.LastName = item.LastName;

			_CustomerRepository.Update(Customer);
			return new NoContentResult();
		}

		[Produces("application/json", Type = typeof(IEnumerable<CustomerItem>))]
		[HttpDelete("{id}")]
		public IActionResult Delete(long id)
		{
			var Customer = _CustomerRepository.Find(id);
			if (Customer == null)
			{
				return NotFound();
			}

			_CustomerRepository.Remove(id);
			return new NoContentResult();
		}

	}
}
