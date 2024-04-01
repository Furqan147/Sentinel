using Maintenance.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Maintenance.Infrastructure.Providers
{
    public class SqlServerProvider : DbContext, IDataProvider
    {
    }
}
