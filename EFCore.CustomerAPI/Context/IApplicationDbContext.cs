using EFCore.CustomerAPI.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.CustomerAPI.Context
{
   public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; set; }

        Task<int> SaveChanges();
    }
}
