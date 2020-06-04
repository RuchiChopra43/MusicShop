using DAO;
using DAO.Models;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly MusicShopDbContext _db;
        public UserRepository(MusicShopDbContext db) : base(db)

        {
            _db = db;
        }

    }
}
