using Microsoft.EntityFrameworkCore;
using ContactosApi.Models;

public class ContactDbContext : DbContext
{
    public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options) { }

    public DbSet<Contact> Contacts { get; set; }
    public DbSet<User> Users { get; set; }
}