using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
	public class BookNotFoundException : NotFoundException
	{
		public BookNotFoundException(int id) : base($"Book with id: {id} could not found.")
		{
		}
	}
}
