﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<EShopApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<MovieApp.Models.Movie> Movies { get; set; }
        public virtual DbSet<MovieApp.Models.Ticket> Tickets { get; set; }
        public DbSet<MovieApp.Models.Order> Order { get; set; } = default!;
        public DbSet<MovieApp.Models.TicketInOrder> TicketInOrders { get; set; } = default!;
    }
}
