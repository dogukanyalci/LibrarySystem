using Library_Core.Entities.Concrete;
using Library_DataAccess.Context;
using Library_DataAccess.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.Services.Concrete
{
    public class UserBookRepository : BaseRepository<UserBook>, IUserBookRepository
    {
        public UserBookRepository(AppDbContext context) : base(context)
        {
        }
    }
}
