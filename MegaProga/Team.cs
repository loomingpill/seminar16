using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProga
{
    class Team
    {
        public int ID { get; set; }
        [MaxLength(69)]
        public string Name { get; set; }
    }
}
