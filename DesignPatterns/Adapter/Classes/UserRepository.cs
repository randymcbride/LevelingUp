using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DesignPatterns.Adapter
{
	public class UserRepository
	{
		private ICsvRepository<User> repository;

		public UserRepository(ICsvRepository<User> repository)
		{
			this.repository = repository;
		}

		public void Insert(User user)
		{
			repository.Insert(user);
		}

		public IEnumerable<User> GetAll() =>
			repository.GetAll();
	}
}
