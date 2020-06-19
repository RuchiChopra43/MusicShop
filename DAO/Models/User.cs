using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Models
{
    public partial class User
    {
       

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime LastLoginDate { get; set; }

        public virtual ICollection<Artist> Artist { get; set; }
        public virtual ICollection<Genre> Genre { get; set; }
        public virtual ICollection<Music> Music { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }

}
