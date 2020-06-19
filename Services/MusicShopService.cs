using System;
using System.Collections.Generic;
using Services.IRepository;

using System.Text;
using Services.Repository;
using DAO;
using DAO.Models;

namespace Services
{
    public class MusicShopService: IMusicShopService
    {
        public MusicShopService(MusicShopDbContext context)
        {
           
            Genre = new GenreRepository(context);
            Music = new MusicRepository(context);
            Artist = new ArtistRepository(context);
            User = new UserRepository(context);
            
        }

        public IGenreRepository Genre { get; set; }
        public IMusicRepository Music { get; set; }
        public IArtistRepository Artist { get; set; }
        public IUserRepository User { get; set; }

    }

}

