using System;

namespace KOffice.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        KOfficeDbContext Init();
    }
}