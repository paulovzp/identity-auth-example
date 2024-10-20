using Microsoft.EntityFrameworkCore;
using PVRC.Identity.Api.Context;

namespace PVRC.Identity.Api.Extensions;

public static class MigrationExtensions
{
    public static void ApplyMigration(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<IdentityApiContext>();
        context.Database.Migrate();
    }
}
