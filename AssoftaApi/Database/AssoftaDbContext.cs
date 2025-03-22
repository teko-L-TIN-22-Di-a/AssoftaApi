using AssoftaApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AssoftaApi.Database;

public class AssoftaDbContext : DbContext
{

    public DbSet<Antrag> AntragSet { get; set; }
    public DbSet<Benutzer> BenutzerSet { get; set; }
    public DbSet<Schadensmeldung> SchadensmeldungsSet { get; set; }

    public AssoftaDbContext(DbContextOptions<AssoftaDbContext> options) : base(options) { }

}