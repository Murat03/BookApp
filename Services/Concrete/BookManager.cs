using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
	public class BookManager : IBookService
	{
		private readonly IRepositoryManager _repositoryManager;

		public BookManager(IRepositoryManager repositoryManager)
		{
			_repositoryManager = repositoryManager;
		}

		public async Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges)
		{
			return await _repositoryManager.BookRepository.GetAllBooksAsync(trackChanges);
		}
	}
}
