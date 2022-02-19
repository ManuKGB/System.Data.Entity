#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetAtlas.Models;

namespace NetAtlas.Data
{
    public class NetAtlasContext : DbContext
    {
        public NetAtlasContext (DbContextOptions<NetAtlasContext> options)
            : base(options)
        {
        }

        public DbSet<NetAtlas.Models.User> User { get; set; }

        public DbSet<NetAtlas.Models.Reply> Reply { get; set; }

        public DbSet<NetAtlas.Models.Comment> Comment { get; set; }
    }
}
