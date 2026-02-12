using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMatchaClub.Domain.Entities
{
    public class BusinessSession
    {
        public int Id { get; set; }

        public string SessionName { get; set; } = string.Empty;

        public DateTime StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public decimal TotalSales { get; set; }

        public bool IsClosed { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
