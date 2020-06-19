using DAO;
using DAO.Models;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Repository
{
    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {

        public GenreRepository(MusicShopDbContext context) : base(context) { }

        public IList<Music> Musicsingenre(int id)
        {
            Genre genre = context.Genre.Find(id);            
            return genre.Music.ToList();
        }

     }     
}
