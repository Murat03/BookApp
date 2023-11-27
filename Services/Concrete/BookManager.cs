using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Exceptions;
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
		private readonly IMapper _mapper;
		public BookManager(IRepositoryManager repositoryManager, IMapper mapper)
		{
			_repositoryManager = repositoryManager;
			_mapper = mapper;
		}
		public async Task CreateOneBook(BookDtoForInsertion bookDto)
		{
			var book = _mapper.Map<Book>(bookDto);
			_repositoryManager.BookRepository.CreateOneBook(book);
			await _repositoryManager.SaveChangesAsync();
		}
		public async Task UpdateOneBook(int id, BookDtoForUpdate bookDto, bool trackChanges) {
			var entity = await GetOneBookByIdAndCheckExistAsync(id, trackChanges);
			_mapper.Map(bookDto, entity);
			_repositoryManager.BookRepository.UpdateOneBook(entity);
			await _repositoryManager.SaveChangesAsync();
		}
		public async Task DeleteOneBook(int id, bool trackChanges) {
			var book = await GetOneBookByIdAndCheckExistAsync(id, trackChanges);
			_repositoryManager.BookRepository.DeleteOneBook(book); 
			await _repositoryManager.SaveChangesAsync();
		}

		public async Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges)
		{
			return await _repositoryManager.BookRepository.GetAllBooksAsync(trackChanges);
		}
		public async Task<Book> GetOneBookByIdAsync(int id, bool trackChanges)
		{
			return await GetOneBookByIdAndCheckExistAsync(id, trackChanges);
		}
		public async Task<Book> GetOneBookByIdAndCheckExistAsync(int id, bool trackChanges)
		{
			var book = await _repositoryManager.BookRepository.GetOneBookByIdAsync(id, trackChanges);
			if (book is null)
				throw new BookNotFoundException(id);
			return book;
		}
	}
}
