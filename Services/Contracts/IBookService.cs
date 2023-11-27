using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
	public interface IBookService
	{
		Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges);
		Task<Book> GetOneBookByIdAsync(int id, bool trackChanges);
		Task CreateOneBook(BookDtoForInsertion bookDto);
		Task UpdateOneBook(int id, BookDtoForUpdate bookDto, bool trackChanges);
		Task DeleteOneBook(int id, bool trackChanges);
	}
}
