namespace KOffice.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private KOfficeDbContext dbContext;

        public KOfficeDbContext Init()
        {
            return dbContext ?? (dbContext = new KOfficeDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}