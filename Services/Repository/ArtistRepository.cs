using DAO;
using DAO.Models;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
    public class ArtistRepository: RepositoryBase<Artist>, IArtistRepository
    {
        private readonly MusicShopDbContext _db;
        public ArtistRepository(MusicShopDbContext db) : base(db)

        {
            _db = db;
        }
    }
}
