using DAO;
using DAO.Models;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
   public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        private readonly MusicShopDbContext _db;
        public GenreRepository(MusicShopDbContext db) : base(db)

        {
            _db = db;
        }

    }
}
