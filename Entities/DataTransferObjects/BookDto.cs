﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
	public record BookDto
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
	}
}
