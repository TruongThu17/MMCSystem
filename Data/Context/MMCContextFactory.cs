﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class MMCContextFactory : IDesignTimeDbContextFactory<MMCDbContext>
    {
        public MMCDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MMCSystem");
            var optionBuilder = new DbContextOptionsBuilder<MMCDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new MMCDbContext(optionBuilder.Options);
        }
    }
}
