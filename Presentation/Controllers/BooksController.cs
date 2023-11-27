using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
	[ApiController]
	[Route("api/books")]
	public class BooksController : ControllerBase
	{
		private readonly IServiceManager _manager;

		public BooksController(IServiceManager manager)
		{
			_manager = manager;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllBooks()
		{
			var books = await _manager.BookService.GetAllBooksAsync(false);
			return Ok(books);
		}
		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetOneBookById([FromRoute(Name ="id")]int id)
		{
			var book = await _manager.BookService.GetOneBookByIdAsync(id, false);
			return Ok(book);
		}
		[HttpPost]
		public async Task<IActionResult> CreateOneBook([FromBody]BookDtoForInsertion bookDto)
		{
			if(bookDto is null)
			{
				return BadRequest();
			}
			await _manager.BookService.CreateOneBook(bookDto);
			return Ok(bookDto);
		}
		[HttpPut("{id:int}")]
		public async Task<IActionResult> UpdateOneBook([FromRoute]int id, [FromBody]BookDtoForUpdate bookDto)
		{
			await _manager.BookService.UpdateOneBook(id, bookDto, false);
			return NoContent();
		}
		[HttpPost("{id:int}")]
		public async Task<IActionResult> DeleteOneBook([FromRoute(Name = "id")]int id)
		{
			await _manager.BookService.DeleteOneBook(id, false);
			return NoContent();
		}
	}
}
