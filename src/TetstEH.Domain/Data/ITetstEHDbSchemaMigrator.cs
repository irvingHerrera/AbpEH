using System.Threading.Tasks;

namespace TetstEH.Data;

public interface ITetstEHDbSchemaMigrator
{
    Task MigrateAsync();
}
