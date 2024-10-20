using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PVRC.Identity.Api.Entities;

namespace PVRC.Identity.Api.Context;

public class IdentityApiContext : IdentityDbContext<User>
{
    public IdentityApiContext(DbContextOptions<IdentityApiContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<User>().Property(x => x.Gender).HasMaxLength(1);
        builder.HasDefaultSchema("identity");
    }
}
