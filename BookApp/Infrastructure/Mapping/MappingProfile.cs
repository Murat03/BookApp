using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace BookApp.Infrastructure.Mapping
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
            CreateMap<BookDtoForUpdate, Book>();
            CreateMap<BookDtoForInsertion, Book>();
        }
    }
}
