using Microsoft.EntityFrameworkCore.Design;

using OpenFinance.Infra.Data.Context;

namespace OpenFinance.Migrations;

/// <summary>
/// Usada pelo `dotnet ef` para instanciar o contexto em design time
/// (migrations add / remove / script / database update).
/// </summary>
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OpenFinanceDbContext>
{
    public OpenFinanceDbContext CreateDbContext(string[] args)
    {
        var connectionString = DatabaseConfiguration.ObterConnectionString();
        return new OpenFinanceDbContext(DatabaseConfiguration.CriarOptions(connectionString));
    }
}
