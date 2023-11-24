using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
	public class BookConfig : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.HasKey(b => b.Id);
			builder.Property(b => b.Title);
			builder.Property(b => b.Body);
			builder.HasData(new Book()
			{
				Id = 1,
				Title = "Title",
				Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
				"Lobortis scelerisque fermentum dui faucibus. In hac habitasse platea dictumst quisque sagittis purus sit. At lectus urna duis convallis " +
				"convallis tellus id interdum. Mauris vitae ultricies leo integer malesuada nunc. Vulputate mi sit amet mauris commodo quis imperdiet massa " +
				"tincidunt. Ultrices gravida dictum fusce ut placerat orci nulla. Interdum velit euismod in pellentesque massa placerat. Quam viverra orci " +
				"sagittis eu volutpat odio facilisis mauris sit. Consequat id porta nibh venenatis cras sed. Malesuada fames ac turpis egestas. Eget dolor morbi " +
				"non arcu risus quis varius quam quisque. Volutpat ac tincidunt vitae semper. Eu mi bibendum neque egestas congue quisque egestas. " +
				"Ultrices tincidunt arcu non sodales. Id ornare arcu odio ut sem nulla pharetra diam sit."
			});
		}
	}
}
