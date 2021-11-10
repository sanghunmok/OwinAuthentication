using Microsoft.AspNet.Identity.EntityFramework;

public class OwinAuthDbContext : IdentityDbContext
{
    public OwinAuthDbContext()
        : base("OwinAuthDbContext")
    {
    }
}