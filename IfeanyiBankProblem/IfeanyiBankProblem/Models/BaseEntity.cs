using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfeanyiBankProblem.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.Now;
            LastUpdated = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; } 
    }
}
