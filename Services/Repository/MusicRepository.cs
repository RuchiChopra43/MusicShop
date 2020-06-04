using DAO;
using DAO.Models;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
    public class MusicRepository : RepositoryBase<Music>, IMusicRepository
    {
        private readonly MusicShopDbContext _db;
        public MusicRepository(MusicShopDbContext db) : base(db)

        {
            _db = db;
        }
    }
}
