using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MLSWebsite.Core;
using MLSWebsite.Core.Interfaces;

namespace MLSWebsite.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        public MlsPortfolioEntities db = null;

        public UserRepository()
        {
            this.db = new MlsPortfolioEntities();
        }
        public UserRepository(MlsPortfolioEntities db)
        {
            this.db = db;
        }


        public void Delete(int id)
        {
            user existing = db.users.Find(id);
            db.users.Remove(existing);
            Save();
        }

        public void Insert(user u)
        {
            db.users.Add(u);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<user> SelectAll()
        {
            return db.users.ToList();
        }

        public user SelectByID(int id)
        {
            return db.users.Find(id);
        }

        public void Update(user u)
        {
            db.Entry(u).State = EntityState.Modified;
            Save();
        }
    }
}

