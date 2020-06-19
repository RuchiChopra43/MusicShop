using DAO.Models;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IMusicShopService
    {
        IGenreRepository Genre { get; set; }
        IMusicRepository Music { get; set; }
        IArtistRepository Artist { get; set; }
        IUserRepository User { get; set; }

        
    }
}