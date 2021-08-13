using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class CategoryDAO
    {
        FreeCyDB db = new FreeCyDB();
        public List<Product> ListAllCategoty(int id_product)
        {
            return db.Products.Where(x => x.Status == 1 && x.ID_Category == id_product).ToList();
        }
        public Category ViewDetail(int cateId)
        {
            return db.Categories.Find(cateId);
        }
    }
}
