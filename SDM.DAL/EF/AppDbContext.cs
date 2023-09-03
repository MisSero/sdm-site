using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SDM.DAL.Entities;

namespace SDM.DAL.EF;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
	public DbSet<TextField> TextFields { get; set; }
	public DbSet<ServiceItem> ServiceItems { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) 
		: base(options) { }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);

		builder.Entity<IdentityRole>().HasData(new IdentityRole
		{
			Id = "dcba78d0-aa5c-464b-98dc-493e3a297af0",
			Name = "admin",
			NormalizedName = "ADMIN"
		});

		builder.Entity<IdentityUser>().HasData(new IdentityUser
		{
			Id = "c3a7a32e-20fa-4935-a495-18ccbb5df3a9",
			UserName = "admin",
			NormalizedUserName = "ADMIN",
			Email = "admin@gmail.com",
			NormalizedEmail = "ADMIN@GMAIL.COM",
			EmailConfirmed = true,
			PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin1"),
			SecurityStamp = string.Empty
		});

		builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
		{
			RoleId = "dcba78d0-aa5c-464b-98dc-493e3a297af0",
			UserId = "c3a7a32e-20fa-4935-a495-18ccbb5df3a9"
		});

		builder.Entity<TextField>().HasData(new TextField
		{
			Id = new Guid("574cc2ea-3eeb-4498-b007-bc537ebf92ff"),
			CodeWord = "PageIndex",
			Title = "Главная страница"
		});
		builder.Entity<TextField>().HasData(new TextField
		{
			Id = new Guid("1573a0a1-2914-4164-ab0d-ebabe87ddc38"),
			CodeWord = "PageService",
			Title = "Услуги"
		});
		builder.Entity<TextField>().HasData(new TextField
		{
			Id = new Guid("9dd7a39a-4bd9-4c21-bc21-88f391cc70ed"),
			CodeWord = "PageContacts",
			Title = "Контанты"
		});
	}
}
