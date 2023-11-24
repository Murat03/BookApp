using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
	public class ServiceManager : IServiceManager
	{
		private readonly IBookService _bookService;

		public ServiceManager(IBookService bookService)
		{
			_bookService = bookService;
		}

		public IBookService BookService => _bookService;
	}
}
