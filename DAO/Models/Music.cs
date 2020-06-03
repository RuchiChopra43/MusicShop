using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Models
{
    public partial class Music
    {
        public Music()
        {
            OrderLine = new HashSet<OrderLine>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int NumTrack { get; set; }
        public int Duration { get; set; }
        public DateTime DateReleased { get; set; }
        public double Price { get; set; }
        public int? ArtistId { get; set; }
        public int? GenreId { get; set; }
        public int? UserId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}
