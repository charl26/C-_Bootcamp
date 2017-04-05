using System;
using System.Collections.Generic;
using System.Linq;

namespace Customer.Models
{
	public class CustomerRepository : ICustomerRepository
	{
		private readonly CustomerContext _context;

		public CustomerRepository(CustomerContext context)
		{
			_context = context;
			Add(new CustomerItem { LastName = "Item1" });
		}

		public IEnumerable<CustomerItem> GetAll()
		{
			return _context.CustomerItems.ToList();
		}

		public void Add(CustomerItem item)
		{
			_context.CustomerItems.Add(item);
			_context.SaveChanges();
		}

		public CustomerItem Find(long key)
		{
			return _context.CustomerItems.FirstOrDefault(t => t.Key == key);
		}

		public void Remove(long key)
		{
			var entity = _context.CustomerItems.First(t => t.Key == key);
			_context.CustomerItems.Remove(entity);
			_context.SaveChanges();
		}

		public void Update(CustomerItem item)
		{
			_context.CustomerItems.Update(item);
			_context.SaveChanges();
		}
	}
}