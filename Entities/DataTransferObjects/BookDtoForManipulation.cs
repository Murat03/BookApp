using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
	public record BookDtoForManipulation
	{
		[Required(ErrorMessage = "Title field is required.")]
		[MinLength(2, ErrorMessage = "Title must consist of at least 2 characters.")]
		[MaxLength(50, ErrorMessage = "Title must consist of at maximum 50 characters.")]
        public string Title { get; init; }
		[Required(ErrorMessage = "Body field is required.")]
		[MinLength(50, ErrorMessage = "Body of book must consist of at least 50 characters.")]
        public string Body { get; init; }
    }
}
