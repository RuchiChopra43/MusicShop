using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Models
{
    public partial class Artist
    {
        public Artist()
        {
            Music = new HashSet<Music>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Music> Music { get; set; }
    }
}
