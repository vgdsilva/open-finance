using Microsoft.EntityFrameworkCore;

using OpenFinance.Infra.Data.Context;
using OpenFinance.Migrations;

// Executor das migrations: `dotnet run --project src/OpenFinance.Migration`
var connectionString = DatabaseConfiguration.ObterConnectionString();

await using var contexto = new OpenFinanceDbContext(DatabaseConfiguration.CriarOptions(connectionString));

var pendentes = (await contexto.Database.GetPendingMigrationsAsync()).ToList();

if (pendentes.Count == 0)
{
    Console.WriteLine("Banco já está atualizado. Nenhuma migration pendente.");
    return 0;
}

Console.WriteLine($"Aplicando {pendentes.Count} migration(s):");
foreach (var migration in pendentes)
    Console.WriteLine($"  - {migration}");

await contexto.Database.MigrateAsync();

Console.WriteLine("Migrations aplicadas com sucesso.");
return 0;
