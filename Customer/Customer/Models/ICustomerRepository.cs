using System.Collections.Generic;

namespace Customer.Models
{
	public interface ICustomerRepository
	{
		void Add(CustomerItem item);
		IEnumerable<CustomerItem> GetAll();
		CustomerItem Find(long key);
		void Remove(long key);
		void Update(CustomerItem item);
	}
}