using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using OpenFinance.Infra.Data.Context;

namespace OpenFinance.Migrations;

/// <summary>
/// Monta as DbContextOptions usadas tanto pelo `dotnet ef` (design time) quanto pelo
/// executor (Program). O ponto-chave é o MigrationsAssembly apontando para ESTE projeto:
/// sem ele o EF procura as migrations no Infra.Data e não encontra nenhuma.
/// </summary>
public static class DatabaseConfiguration
{
    public const string ConnectionStringName = "OpenFinance";

    public static string ObterConnectionString()
    {
        // appsettings.json < appsettings.Local.json (fora do git, guarda a senha)
        // < variável de ambiente ConnectionStrings__OpenFinance
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile("appsettings.Local.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        return configuration.GetConnectionString(ConnectionStringName)
            ?? throw new InvalidOperationException(
                $"Connection string '{ConnectionStringName}' não configurada (appsettings.json ou ConnectionStrings__{ConnectionStringName}).");
    }

    public static DbContextOptions<OpenFinanceDbContext> CriarOptions(string connectionString)
    {
        return new DbContextOptionsBuilder<OpenFinanceDbContext>()
            .UseNpgsql(connectionString, npgsql =>
                npgsql.MigrationsAssembly(typeof(DatabaseConfiguration).Assembly.GetName().Name))
            .Options;
    }
}
