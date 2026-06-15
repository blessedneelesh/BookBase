using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBase.Repository.Interface
{
    public interface IRepositoryContext
    {
        IDbConnection GetDatabaseConnection();
    }
}
