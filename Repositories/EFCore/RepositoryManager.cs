using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
	public class RepositoryManager : IRepositoryManager
	{
		private readonly IBookRepository _bookRepository;

		public RepositoryManager(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository;
		}

		public IBookRepository BookRepository => _bookRepository;
	}
}
