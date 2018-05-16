using Events.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Data
{
    public class EventsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public EventsContext(DbContextOptions<EventsContext> options)
            : base(options)
        { }
    }
}
