using System.Reflection;

using Microsoft.EntityFrameworkCore;

using OpenFinance.Domain.Attributes;
using OpenFinance.Domain.Entities;

namespace OpenFinance.Infra.Data.Context;

/// <summary>
/// Único DbContext do sistema. Não sobrescreve OnConfiguring: quem usa (API, projeto
/// de Migration, testes) decide o provider e a connection string via DbContextOptions.
/// As migrations NÃO ficam aqui, ficam no projeto OpenFinance.Migration.
/// </summary>
public class OpenFinanceDbContext(DbContextOptions<OpenFinanceDbContext> options) : DbContext(options)
{
    public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
    public DbSet<ApplicationSettings> ApplicationSettings => Set<ApplicationSettings>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Mapeamentos extras (IEntityTypeConfiguration<T>) que vierem a existir neste assembly.
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OpenFinanceDbContext).Assembly);

        IgnorarPropriedadesTransientes(modelBuilder);
    }

    /// <summary>Propriedades marcadas com [Transiente] não viram coluna.</summary>
    private static void IgnorarPropriedadesTransientes(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes().ToList())
        {
            var transientes = entityType.ClrType
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.IsDefined(typeof(TransienteAttribute), inherit: true));

            foreach (var propriedade in transientes)
                modelBuilder.Entity(entityType.ClrType).Ignore(propriedade.Name);
        }
    }
}
