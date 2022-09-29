using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.Concrete;
using Crm.DataAccessLayer.Repository;
using Crm.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        Context context = new Context();
        public List<Product> GetListProductWithCategory()
        {
            return context.Products.Include(x => x.Category).ToList();
        }
    }
}
