using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProga
{
    class Context : DbContext
    {
        DbSet <Player> Players;
        DbSet <Team> Teams;
    }
}
