using AutoMapper;
using Library_Core.DTO_s.AuthorDTO;
using Library_Core.DTO_s.BookDTO;
using Library_Core.DTO_s.GenreDTO;
using Library_Core.DTO_s.PublisherDTO;
using Library_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Book, AddBookDTO>().ReverseMap();
            CreateMap<Book, UpdateBookDTO>().ReverseMap();
            CreateMap<Book, BookDetailsDTO>().ReverseMap();

            CreateMap<Author, AddAuthorDTO>().ReverseMap();
            CreateMap<Author, UpdateAuthorDTO>().ReverseMap();

            CreateMap<Genre, AddGenreDTO>().ReverseMap();
            CreateMap<Genre, UpdateGenreDTO>().ReverseMap();

            CreateMap<Publisher, AddPublisherDTO>().ReverseMap();
            CreateMap<Publisher, UpdatePublisherDTO>().ReverseMap();

        }
    }
}
