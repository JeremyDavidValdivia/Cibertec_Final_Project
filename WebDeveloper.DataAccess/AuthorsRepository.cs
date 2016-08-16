using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;

namespace WebDeveloper.DataAccess
{
    public class AuthorsRepository : BaseDataAccess<Authors>
    {
        public IEnumerable<AuthorsModelView> GetListDto()
        {
            using (var dbContext = new WebContextDb())
            {
                return Automapper.GetGeneric<IEnumerable<Authors>,List<AuthorsModelView>>(dbContext.Authors.ToList().OrderByDescending(x=> x.au_lname));
            }
        }

        public Authors GetById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Authors.FirstOrDefault(p => p.au_id == id);
            }
        }
    }
}
