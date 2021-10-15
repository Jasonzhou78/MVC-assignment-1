using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FindPet.Models;

namespace FindPet.Data
{
    public class FindPetContext : DbContext
    {
        public FindPetContext (DbContextOptions<FindPetContext> options)
            : base(options)
        {
        }

        public DbSet<FindPet.Models.Pet> Pet { get; set; }
    }
}
