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
        public ArtistRepository(MusicShopDbContext context) : base(context) { }
    }
}
