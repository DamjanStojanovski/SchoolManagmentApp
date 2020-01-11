using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class BaseRepository
    {
        protected readonly SchoolDBCOntext _dbContext;
        public BaseRepository(SchoolDBCOntext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
