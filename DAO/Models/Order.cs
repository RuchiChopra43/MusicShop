using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Models
{
    public partial class Order
    {
        
        public int Id { get; set; }
        public string DelAddress { get; set; }
        public DateTime DateCreated { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}
