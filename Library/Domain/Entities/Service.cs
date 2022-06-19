using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Service
    {

        public int ID { get; set; }
        public string Service_Name { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
