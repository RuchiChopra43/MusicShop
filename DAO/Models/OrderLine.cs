using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Models
{
    public partial class OrderLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int? OrderId { get; set; }
        public int? MusicId { get; set; }

        public virtual Music Music { get; set; }
        public virtual Order Order { get; set; }
    }
}
