using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Jazani.Infrastructure.Cores.Contexts
{
    public class ApplicationDbContext: DbContext
    {
        //Las variables de tipo privado y de tipo lectura que serán inyectadas
        ///suelen ser escritas con un "_" al inicio
        private readonly IConfiguration _configuration;

        //Creando constructor
        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DbConnection"));
        }
    }
}
