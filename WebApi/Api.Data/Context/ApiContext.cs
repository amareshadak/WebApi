﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class ApiContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}