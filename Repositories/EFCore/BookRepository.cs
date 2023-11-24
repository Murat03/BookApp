using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
	public class BookRepository : RepositoryBase<Book>, IBookRepository
	{
		public BookRepository(RepositoryContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges)
		{
			return await FindAll(trackChanges).ToListAsync();
		}
	}
}
