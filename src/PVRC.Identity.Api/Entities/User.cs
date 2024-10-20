using Microsoft.AspNetCore.Identity;

namespace PVRC.Identity.Api.Entities;

public class User : IdentityUser
{
    public string? Gender { get; set; }
}
