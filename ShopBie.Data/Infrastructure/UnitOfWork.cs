using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBie.Data.Infrastructure
{
    public class UnitOfWork : IUnitOFWork
    {
        private readonly IDbFactory dbFactory;
        private ShopBieDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ShopBieDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            // phương thức của DbContext
            DbContext.SaveChanges();
        }
    }
}