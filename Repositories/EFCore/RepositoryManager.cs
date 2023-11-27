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
		private readonly RepositoryContext _context;

		public RepositoryManager(IBookRepository bookRepository, RepositoryContext context)
		{
			_bookRepository = bookRepository;
			_context = context;
		}

		public IBookRepository BookRepository => _bookRepository;

		public async Task SaveChangesAsync()
		{
			await _context.SaveChangesAsync();
		}
	}
}
