using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBie.Data.Infrastructure
{
        // viết theo cái bestpratice cho ngắn gọn
    public class DbFactory : Disposable, IDbFactory
    {
        // khai báo 1 biến
        private ShopBieDbContext dbContext;

        public ShopBieDbContext Init()
        {
            // ?? -> Null thì khởi tạo 1 cái new
            return dbContext ?? (dbContext = new ShopBieDbContext());
        }

        protected override void DisposeCore()
        {
            // khác null dispose nó sẽ chạy
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
