using Library_Core.Entities.Concrete;
using Library_DataAccess.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.Services.Concrete
{
    public class AuthorPublisherRepository : BaseRepository<AuthorPublisher>, IAuthorPublisherRepository
    {
        public AuthorPublisherRepository(AppDbContext context) : base(context)
        {
        }
    }
}
