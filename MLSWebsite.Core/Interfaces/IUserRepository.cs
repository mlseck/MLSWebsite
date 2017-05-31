using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSWebsite.Core.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<user> SelectAll();
        user SelectByID(int id);
        void Insert(user obj);
        void Update(user obj);
        void Delete(int id);
        void Save();
    }
}
